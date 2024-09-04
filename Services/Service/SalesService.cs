using Common.Dtos;
using Common.Helper;
using Common.ViewModels;
using DataContext.DataClasses;
using Repositories.IRepository;
using Repositories.Repository;
using Services.IService;
using System.Text.Json;
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
        public async Task<APIResponse<string>> AddBuyerDetails(AddBuyerDto buyerDto)
        {
            var addBuyer = await _salesRepository.AddBuyerDetails(buyerDto);
            if (addBuyer == null)
            {
                return ResponseHelper<string>.CreateExceptionErrorResponse(HttpStatusCode.Conflict, new List<string> { "Buyer already exists" });
            }
            return ResponseHelper<string>.CreateSuccessRes(addBuyer.ToString(), new List<string> { "Buyer added successfully" });
        }
        public async Task<APIResponse<List<GetbuyerDetailsResult>>> GetBuyerDetails(string search)
        {
            var buyerList = await _salesRepository.GetBuyerDetails(search);
            if (buyerList == null || !buyerList.Any())
            {
                return ResponseHelper<List<GetbuyerDetailsResult>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No Buyer found" });
            }
            return ResponseHelper<List<GetbuyerDetailsResult>>.CreateGetSuccessResponse(buyerList, buyerList.Count());
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
        public async Task<APIResponse<LandCoordinateVm>> GetLandCoordinates(int landId)
        {
            var result = await _salesRepository.GetLandCoordinates(landId);
            if (result == null)
            {
                return ResponseHelper<LandCoordinateVm>.CreateExceptionErrorResponse(HttpStatusCode.Conflict, new List<string> { "Coordinates not found" });
            }
            var landShapeArray = JsonSerializer.Deserialize<List<LandShape>>(result.LandShapeArray);

            var landCoordinateVm = new LandCoordinateVm
            {
                MapId = result.Id,
                Latitude = result.Latitude,
                Longitude = result.Longitude,
                LandShapeArray = landShapeArray
            };
            return ResponseHelper<LandCoordinateVm>.CreateSuccessRes(landCoordinateVm, new List<string> { "Coordinates fetched successfully" });
        }       

    }
}
