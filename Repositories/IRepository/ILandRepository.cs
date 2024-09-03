using Common.Dtos;
using Common.Helper;
using DataContext.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface ILandRepository
    {
        Task<GetLandDetailsFiltersResult> GetLandDetails(int landId, string? deptt);
        Task<List<GetLandByAssetIdResult>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, int? IsWlt);
        Task<AddBuyerDetailsResult> AddBuyerDetails(AddBuyerDto buyerDto);
        Task<List<GetbuyerDetailsResult>> GetBuyerDetails(string search);
        Task<int> Updateland(UpdateLandDto landDto);
    }
}
