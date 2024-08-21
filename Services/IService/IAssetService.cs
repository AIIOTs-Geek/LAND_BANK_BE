using Common.Helper;
using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IAssetService
    {        
        Task<APIResponse<List<StatusVm>>> GetStatus(string statusType);
        Task<APIResponse<List<AssetVm>>> GetAssets();
        Task<APIResponse<List<CityVm>>> GetCities();
        Task<APIResponse<List<DistrictVm>>> GetDistrictsByCityId(int cityId);
    }
}
