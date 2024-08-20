using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IAssetRepository
    {
        Task<StatusVm> GetStatus(string statusType);       
    }
}
