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
        Task<GetLandDetailForViewerResult> GetLandDetailsForViewer(int landId, string? deptt);
        Task<List<GetLandByAssetIdResult>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, int? IsWlt, int pageno,int pagesize);
        Task<List<GetLandByAssetIdForViewerResult>> GetLandsByAssetIdForViewer(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, int? IsWlt, int pageno, int pagesize);
        Task<int> Updateland(UpdateLandDto landDto);
        Task<int> LandUpdateAction(LandUpdateActionDto actionDto);
        Task<int> UpdateBuyerDetails(AddBuyerDto buyerDto);
        Task<int> UpsertFinance(UpsertFinanceDto upsertFinance);
        Task<int> UpsertTitleDeed(UpsertTitleDeedDto upsertTitleDeed);
    }
}
