using Common.Helper;
using Common.ViewModels;
using DataContext.DataClasses;
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
        Task<APIResponse<List<AssetNameVm>>> GetAssets();
        Task<APIResponse<List<CityVm>>> GetCities();
        Task<APIResponse<List<DistrictVm>>> GetDistrictsByCityId(int cityId);
        Task<APIResponse<List<AssetVm>>> GetAssets(string? searchText, int? cityId, int? districtId, int? assetId);
    }
}
