using Common.Helper;
using Common.ViewModels;
using DataContext.DataClasses;
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
    public class AssetService : IAssetService
    {
        private readonly IAssetRepository _assetRepository;
        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }
        public async Task<APIResponse<List<StatusVm>>> GetStatus(string statusType)
        {
            var statusVmList = new List<StatusVm>();
            var statusList = await _assetRepository.GetStatus(statusType);
            if (statusList == null || !statusList.Any())
            {
                return ResponseHelper<List<StatusVm>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No status found" });
            }

            foreach (var item in statusList)
            {
                var statusVm = new StatusVm
                {
                    Id = item.Id,
                    Status = item.Status
                };

                statusVmList.Add(statusVm);
            }
            return ResponseHelper<List<StatusVm>>.CreateGetSuccessResponse(statusVmList, statusList.Count);
        }
        public async Task<APIResponse<List<AssetNameVm>>> GetAssets()
        {
            var assetVmList = new List<AssetNameVm>();
            var assetList = await _assetRepository.GetAssetNames();
            if (assetList == null || !assetList.Any())
            {
                return ResponseHelper<List<AssetNameVm>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No assets found" });
            }

            foreach (var item in assetList)
            {
                var assetVm = new AssetNameVm
                {
                    Id = item.Id,
                    AssetName = item.AssetName
                };

                assetVmList.Add(assetVm);
            }
            return ResponseHelper<List<AssetNameVm>>.CreateGetSuccessResponse(assetVmList, assetVmList.Count);
        }
        public async Task<APIResponse<List<CityVm>>> GetCities()
        {
            var cityVmList = new List<CityVm>();
            var cityList = await _assetRepository.GetAllCities();
            if (cityList == null || !cityList.Any())
            {
                return ResponseHelper<List<CityVm>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No cities found" });
            }

            foreach (var item in cityList)
            {
                var cityVm = new CityVm
                {
                    Id = item.Id,
                    CityName = item.CityName
                };

                cityVmList.Add(cityVm);
            }
            return ResponseHelper<List<CityVm>>.CreateGetSuccessResponse(cityVmList, cityVmList.Count);
        }
        public async Task<APIResponse<List<DistrictVm>>> GetDistrictsByCityId(int cityId)
        {
            var districtVmList = new List<DistrictVm>();
            var districtList = await _assetRepository.GetDistrictsByCityId(cityId);
            if (districtList == null || !districtList.Any())
            {
                return ResponseHelper<List<DistrictVm>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No districts found" });
            }

            foreach (var item in districtList)
            {
                var districtVm = new DistrictVm
                {
                    Id = item.Id,
                    DistrictName = item.DistrictName,
                };

                districtVmList.Add(districtVm);
            }
            return ResponseHelper<List<DistrictVm>>.CreateGetSuccessResponse(districtVmList, districtList.Count);
        }
        public async Task<APIResponse<List<AssetVm>>> GetAssets(string? search, int? cityId, int? districtId, int? assetId)
        {
            var assetsVmList = new List<AssetVm>();
            var assetsList = await _assetRepository.GetAssets(search, cityId, districtId, assetId);
            if (assetsList == null || !assetsList.Any())
            {
                return ResponseHelper<List<AssetVm>>.CreateExceptionErrorResponse(HttpStatusCode.NotFound, new List<string> { "No assets found" });
            }

            foreach (var item in assetsList)
            {
                var assetVm = new AssetVm
                {
                    AssetId = item.AssetId,
                    AssetName = item.AssetName,
                    SubAssetName = item.SubAssetName,
                    LandCount = item.NumberOfLands,
                    TotalArea = item.TotalLandArea,
                };

                assetsVmList.Add(assetVm);
            }
            return ResponseHelper<List<AssetVm>>.CreateGetSuccessResponse(assetsVmList, assetsVmList.Count);
        }
    }
}
