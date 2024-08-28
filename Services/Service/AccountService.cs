using Common;
using Common.Dtos.Login;
using Common.Helper;
using Common.ViewModels;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Constant = Common.Constant;
using Common.Helpers;

namespace Services.Service
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;
        private readonly LBDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public AccountService(IAccountRepository accountRepository, LBDbContext dbContext, IConfiguration configuration)
        {
            _accountRepository = accountRepository;
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public async Task<APIResponse<LoginViewModel>> Login(LoginDto loginDto)
        {
            try
            {
               
                var user = await _accountRepository.Login(loginDto);
                if (user == null)
                {
                    return ResponseHelper<LoginViewModel>.CreateErrorRes(null, HttpStatusCode.Unauthorized, new List<string> { "UserId not Found" });
                }
                if (user.RoleId == 1)
                {
                    // Fetch users from AD
                  //  var usersResponse = await _userService.GetUsersFromAD();

                    if (!usersResponse.Success)
                    {
                        return ResponseHelper<LoginViewModel>.CreateErrorRes(null, new List<string> { "UserId not Found" });
                    }

                    // Get the list of users from the response
                    var users = usersResponse.Data;

                    // Check if the email exists in the users list
                    //var userfromAD = users.FirstOrDefault(u => u.UserPrincipalName.Equals(loginDto.Email, StringComparison.OrdinalIgnoreCase));

                    if (userfromAD == null)
                    {

                        return ResponseHelper<LoginViewModel>.CreateErrorRes(null, HttpStatusCode.Unauthorized, new List<string> { "UserId Not Found" });

                    }
                }

                // Verify password

                if (!VerifyPassword(loginDto.Password, user.Password))
                {
                    // Authentication successful
                    return ResponseHelper<LoginViewModel>.CreateErrorRes(null, HttpStatusCode.Unauthorized, new List<string> { "Incorrect Password" });
                }

                var token = JWTToken.GenerateJWTToken(_configuration, user);

             //   var sign = await _dbContext.SystemConfiguration.FirstOrDefaultAsync();

                return ResponseHelper<LoginViewModel>.CreateSuccessResponses(new LoginViewModel
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo,
                    RoleName = user.Role.RoleName,
                    RoleId = user.RoleId,
                    FirstName = user.FName,
                    LastName = user.LName,
                    Email = user.Email,
                    MobilePhone = user.MobilePhone,
                    displayname = user.DisplayName,
                    Position = user.Position,
                    Id = user.Id,
                    Department = user.Department.DepartmentNameEn,
                    company = user.Company.CompanyNameEn,
                    PhysicalSignature = sign.IsSignatureEnabled,
                    //HasMultipleRoles = hasMultipleRoles,
                    // SignatureImage = signatureBase64

                }, new List<string> { Constant.SuccessfulLogin });
            }
            catch (Exception ex)
            {
                // Log the error
                return ResponseHelper<LoginViewModel>.CreateErrorRes(null, new List<string> { ex.Message });
            }
        }
    }
}
