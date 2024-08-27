﻿using Common.Helper;
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
    public class LandService : ILandService
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
                IsWlt = landDetails.WLTStatus,
                Masterplan = landDetails.MasterPlan,
                InfraApproval = landDetails.InfraApproval,
                InfraContraction = landDetails.InfraContraction,
                MunHandingOver = landDetails.MHandingOver,
                TitleDeed = new TitleDeed
                {
                    DeedNumber = landDetails.TDNo,
                    DeedType = landDetails.TDType,
                    DeedStatus = landDetails.TitleDeedStatus,
                    Owner =landDetails.TDOwnership,
                    DeedDate = landDetails.TDDate,
                },
                OwnerShipDetails = new List<TitleDeed>()

            };
            if (!string.IsNullOrEmpty(landDetails.TitleDeeds))
            {
                var jsonTitleDeeds = landDetails.TitleDeeds;
                landDetailsVm.OwnerShipDetails = JsonSerializer.Deserialize<List<TitleDeed>>(jsonTitleDeeds);
            }                    


            return ResponseHelper<LandDetailsVm>.CreateSuccessRes(landDetailsVm, new List<string> { "Land details fetched successfully" });
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
                    WLTStatus = item.IsWlt
                };

                landVmList.Add(landVm);
            }
            return ResponseHelper<List<LandByAssetIdVm>>.CreateGetSuccessResponse(landVmList, landVmList.Count);
        }
    }
}
