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
using Common.Dtos;
using Models.Models.UserDetails;

namespace Services.Service
{
    public class LandService : ILandService
    {
        private readonly ILandRepository _landRepository;
        public LandService(ILandRepository landRepository)
        {
            _landRepository = landRepository;
        }
        public async Task<APIResponse<LandDetailsVm>> GetLandDetails(int landId, string? deptt)
        {
            try
            {
                var landDetails = await _landRepository.GetLandDetails(landId, deptt);
                if (landDetails == null)
                {
                    return ResponseHelper<LandDetailsVm>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No details found for this land" });
                }

                var landDetailsVm = new LandDetailsVm
                {
                    LandId = landDetails.LandId,
                    ReferenceId = landDetails.ReferenceNumber,
                    MapUrl = landDetails.MapImageURL,
                    LandInformation = landDetails.LandInformation,
                    LandStatus = landDetails.LandStatus,
                    LandType = landDetails.LandType,
                    LandUse = landDetails.LandUse,
                    BusinessPlan = landDetails.BusinessPlanName,
                    BusinessPlanDetail = landDetails.BusinessPlanDetails,
                    BusinessPlanStatus = landDetails.BusinessPlanStatus,
                    City = landDetails.CityName,
                    District = landDetails.DistrictName,
                    SubAssetCode = landDetails.SubAssetCode,
                    SubAssetName = landDetails.SubAssetName,
                    AssetCode = landDetails.AssetCode,
                    AssetName = landDetails.AssetName,
                    Area = landDetails.Area,
                    Location = landDetails.Location,
                    Latitude = landDetails.Latitude,
                    Longitude = landDetails.Longitude,
                    IsWlt = landDetails.WLTStatus,
                    Masterplan = landDetails.MasterPlan,
                    InfraApproval = landDetails.InfraApproval,
                    InfraContraction = landDetails.InfraContraction,
                    MunHandingOver = landDetails.MHandingOver,
                    PlotNo = landDetails.PlotNo,
                    TitleDeed = new TitleDeed
                    {
                        DeedNumber = landDetails.TDNo,
                        DeedType = landDetails.TDType,
                        DeedStatus = landDetails.TitleDeedStatus,
                        Owner = landDetails.TDOwnership,
                        DeedDate = landDetails.TDDate,
                    },
                    OwnerShipDetails = new List<TitleDeed>(),
                    SaleDetails = new SaleDetailsVm()
                };
                if (!string.IsNullOrEmpty(landDetails.TitleDeeds))
                {
                    var jsonTitleDeeds = landDetails.TitleDeeds;
                    landDetailsVm.OwnerShipDetails = JsonSerializer.Deserialize<List<TitleDeed>>(jsonTitleDeeds);
                }
                if (!string.IsNullOrEmpty(landDetails.Sales))
                {
                    var jsonSales = landDetails.Sales;
                    landDetailsVm.SaleDetails = JsonSerializer.Deserialize<SaleDetailsVm>(jsonSales);
                }
                if (!string.IsNullOrEmpty(landDetails.Finance))
                {
                    var jsonFinance = landDetails.Finance;
                    landDetailsVm.FinanceDetails = JsonSerializer.Deserialize<FinanceVm>(jsonFinance);
                }
                if (!string.IsNullOrEmpty(landDetails.Wlt))
                {
                    var jsonWlt = landDetails.Wlt;                    
                    landDetailsVm.WhiteLandDetails = JsonSerializer.Deserialize<List<WltWrapperVm>>(jsonWlt);
                }

                return ResponseHelper<LandDetailsVm>.CreateSuccessRes(landDetailsVm, new List<string> { "Land details fetched successfully" });
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");
            }
        }
        public async Task<APIResponse<List<LandByAssetIdVm>>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, int? IsWlt)
        {
            var landVmList = new List<LandByAssetIdVm>();
            var landList = await _landRepository.GetLandsByAssetId(assetId, searchText, cityId, districtId, userId, landUseId, businessPlanId, IsWlt);
            if (landList == null || !landList.Any())
            {
                return ResponseHelper<List<LandByAssetIdVm>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No land found" });
            }

            foreach (var item in landList)
            {
                var landVm = new LandByAssetIdVm
                {
                    LandId = item.LandId,
                    ReferenceNumber = item.ReferenceNumber,
                    Location = item.Location,
                    LandArea = item.Area,
                    CityName = item.CityName,
                    DistrictName = item.DistrictName,
                    LandStatus = item.LandStatus,
                    LandType = item.LandType,
                    LandUse = item.LandUse,
                    AssetName = item.AssetName,
                    SubAssetName = item.SubAssetName,
                    DeedType = item.LandDeed,
                    DeedOwner = item.DeedOwner,
                    BusinessPlan = item.BusinessPlan,
                    WLTStatus = item.IsWlt,
                    DeedStatus = item.TitleDeedStatus,
                    Status = item.RandomNumber,
                };

                landVmList.Add(landVm);
            }
            return ResponseHelper<List<LandByAssetIdVm>>.CreateGetSuccessResponse(landVmList, landVmList.Count);
        }
        public async Task<APIResponse<string>> AddBuyerDetails(AddBuyerDto buyerDto)
        {
            var addBuyer = await _landRepository.AddBuyerDetails(buyerDto);
            if (addBuyer == null) 
            {
                return ResponseHelper<string>.CreateExceptionErrorResponse(HttpStatusCode.Conflict, new List<string> { "Buyer already exists" });
            }
            return ResponseHelper<string>.CreateSuccessRes(addBuyer.ToString(), new List<string> { "Buyer added successfully"});
        }
        public async Task<APIResponse<List<GetbuyerDetailsResult>>> GetBuyerDetails(string search)
        {
           // var landVmList = new List<GetbuyerDetailsResult>();
            var buyerList = await _landRepository.GetBuyerDetails(search);
            if (buyerList == null || !buyerList.Any())
            {
                return ResponseHelper<List<GetbuyerDetailsResult>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No Buyer found" });
            }
            return ResponseHelper<List<GetbuyerDetailsResult>>.CreateGetSuccessResponse(buyerList, buyerList.Count());
        }
    }
}
