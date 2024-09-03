using Common.Dtos;
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
    public interface ILandService
    {
        Task<APIResponse<LandDetailsVm>> GetLandDetails(int landId, string? deptt);
        Task<APIResponse<List<LandByAssetIdVm>>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, int? IsWlt);
        Task<APIResponse<string>> AddBuyerDetails(AddBuyerDto buyerDto);
        Task<APIResponse<List<GetbuyerDetailsResult>>> GetBuyerDetails(string search);
        Task<APIResponse<string>> UpdateLand(UpdateLandDto landDto);
        Task<APIResponse<string>> UpdateBuyerDetails(AddBuyerDto buyerDto);

    }
}
