using Common.Dtos.Login;
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
        public async Task<User> Login(LoginDto loginDto)
        {
            var result = new User();

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {

            }
            return result;
        }
    }
}
