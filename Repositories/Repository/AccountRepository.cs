using Common.ViewModels;
using DataContext;
using DataContext.DataClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Models.UserDetails;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class AccountRepository : IAccountRepository
    {

        private readonly LBDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public AccountRepository(LBDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }
        public async Task<UserLoginResult> Login(string email)
        {
            var result = new UserLoginResult();
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.UserLogin(email).SingleOrDefault();

                if (result == null)
                {
                    return null;
                }
            }
            return result;
        }
    }
}
