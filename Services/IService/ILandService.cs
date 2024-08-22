using Common.Helper;
using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface ILandService
    {
        Task<APIResponse<LandDetailsVm>> GetLandDetails(int landId, string? deptt);
    }
}
