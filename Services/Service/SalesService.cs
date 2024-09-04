using Common.Dtos;
using Common.Helper;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class SalesService:ISalesService
    {
        private readonly ISalesRepository _salesRepository;
        public SalesService(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }
        public async Task<APIResponse<string>> UpdateLandCoordinated(UpdateLandCoordinateDto landCoordinateDto)
        {
            var result = await _salesRepository.UpdateLandCoordinates(landCoordinateDto);
            if (result == 0)
            {
                return ResponseHelper<string>.CreateExceptionErrorResponse(HttpStatusCode.Conflict, new List<string> { "Coordinates not updated" });
            }
            return ResponseHelper<string>.CreateSuccessRes(result.ToString(), new List<string> { "Coordinates updated successfully" });
        }
    }
}
