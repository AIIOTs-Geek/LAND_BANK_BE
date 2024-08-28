using DataContext.DataClasses;
using Models.Models.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IAccountRepository
    {
        Task<UserLoginResult> Login(string email);
    }
}
