using Common.Dtos;
using DataContext.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface ISalesRepository
    {
        Task<AddBuyerDetailsResult> AddBuyerDetails(AddBuyerDto buyerDto);
        Task<List<GetbuyerDetailsResult>> GetBuyerDetails(string search);
        Task<int> UpdateLandCoordinates(UpdateLandCoordinateDto landCoordinateDto);
        Task<GetLandCoordinatesResult> GetLandCoordinates(int landId);
    }
}
