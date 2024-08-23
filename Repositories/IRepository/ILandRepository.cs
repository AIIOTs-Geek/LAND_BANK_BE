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
        Task<GetLandDetailsResult> GetLandDetails(int landId, string? deptt);
        Task<List<GetLandByAssetIdResult>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, bool? IsWlt);
    }
}
