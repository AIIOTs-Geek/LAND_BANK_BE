using Common.Dtos.Login;
using Common.Helper;
using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IAccountService
    {
        Task<APIResponse<LoginViewModel>> Login(LoginDto loginDto);
    }
}
