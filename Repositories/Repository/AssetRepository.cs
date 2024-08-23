using Common.Helper;
using Common.ViewModels;
using DataContext.DataClasses;
using Microsoft.Extensions.Configuration;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class AssetRepository : IAssetRepository
    {
        private readonly IConfiguration _configuration;
        public AssetRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<GetStatusResult>> GetStatus(string statusType)
        {
            var result = new List<GetStatusResult>();

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetStatus(statusType).ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }
        public async Task<List<GetAssetNamesResult>> GetAssetNames()
        {
            var result = new List<GetAssetNamesResult>();

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetAssetNames().ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }
        public async Task<List<GetCitiesResult>> GetAllCities()
        {
            var result = new List<GetCitiesResult>();

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetCities().ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }
        public async Task<List<GetDistrictByCityIdResult>> GetDistrictsByCityId(int cityId)
        {
            var result = new List<GetDistrictByCityIdResult>();

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetDistrictByCityId(cityId).ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }
        public async Task<List<GetAssetsWithLandCountResult>> GetAssets(string? searchText, int? cityId, int? districtId, int? assetId)
        {
            var result = new List<GetAssetsWithLandCountResult>();

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetAssetsWithLandCount(searchText, cityId, districtId, assetId).ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }
    }
}
