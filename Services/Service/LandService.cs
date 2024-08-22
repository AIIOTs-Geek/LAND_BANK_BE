using Common.Helper;
using Common.ViewModels;
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
    public class LandService:ILandService
    {
        private readonly ILandRepository _landRepository;
        public LandService(ILandRepository landRepository)
        {
            _landRepository = landRepository; 
        }
        public async Task<APIResponse<LandDetailsVm>> GetLandDetails(int landId, string? deptt)
        {
            var landDetails = await _landRepository.GetLandDetails(landId, deptt);
            if (landDetails == null)
            {
                return ResponseHelper<LandDetailsVm>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No details found for this land" });
            }
            
                var landDetailsVm = new LandDetailsVm
                {
                    Id = landDetails.LandId,
                    LandInformation = landDetails.LandInformation,
                    LandStatus = landDetails.LandStatus,
                    LandType = landDetails.LandType,
                    LandUse = landDetails.LandUse,
                    BusinessPlan = landDetails.BusinessPlanDetailed,
                    City = landDetails.CityName,
                    District = landDetails.DistrictName,
                    SubAssetCode= landDetails.SubAssetCode,
                    SubAssetName= landDetails.SubAssetName,
                    AssetCode= landDetails.AssetCode,   
                    AssetName= landDetails.AssetName,
                    Area = landDetails.Area,
                    Location = landDetails.Location,                    
                };

            return ResponseHelper<LandDetailsVm>.CreateSuccessRes(landDetailsVm, new List<string> { "Land details fetched successfully"});
        }
    }
}
