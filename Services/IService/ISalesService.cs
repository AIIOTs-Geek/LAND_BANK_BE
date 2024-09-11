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
    public interface ISalesService
    {
        Task<APIResponse<string>> AddBuyerDetails(AddBuyerDto buyerDto);
        Task<APIResponse<List<GetbuyerDetailsResult>>> GetBuyerDetails(string search);
        Task<APIResponse<string>> UpdateLandCoordinated(UpdateLandCoordinateDto landCoordinateDto);
        Task<APIResponse<LandCoordinateVm>> GetLandCoordinates(int landId);

        Task<APIResponse<string>> upsertSale(UpsertSaleDto upsertSaleDto);
    }
}
