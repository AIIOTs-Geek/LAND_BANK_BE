using Common.Dtos;
using Common.ViewModels;
using DataContext.DataClasses;
using Microsoft.Extensions.Configuration;
using Models.Models.UserDetails;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class LandRepository : ILandRepository
    {
        private readonly IConfiguration _configuration;
        public LandRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<GetLandDetailsFiltersResult?> GetLandDetails(int landId, string? deptt)
        {
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = db.GetLandDetailsFilters(landId, deptt, userId).SingleOrDefault();
                if (result == null)
                {
                    return null;
                }

                return result;
            }
        }
        public async Task<List<GetLandByAssetIdResult>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? ownerId, int? landUseId, int? businessPlanId, int? IsWlt , int pageNo , int pageSize )
        {
            var result = new List<GetLandByAssetIdResult>();
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetLandByAssetId(assetId, searchText, cityId, districtId, ownerId, landUseId, businessPlanId, IsWlt, userId,pageNo,pageSize).ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }
        public async Task<AddBuyerDetailsResult> AddBuyerDetails(AddBuyerDto buyerDto)
        {
            var result = new AddBuyerDetailsResult();
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
               result = db.AddBuyerDetails(userId, buyerDto.BuyerId, buyerDto.BuyerName, buyerDto.CompanyId, buyerDto.BuyerEmail,buyerDto.BuyerMobile).SingleOrDefault();

                if (result == null)
                {
                    return null;
                }
            }
            return result;
        }
        public async Task<List<GetbuyerDetailsResult>> GetBuyerDetails(string search)
        {
            var result = new List<GetbuyerDetailsResult>();
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetbuyerDetails(search, userId).ToList();

                if (result == null)
                {
                    return null;
                }
            }
            return result;
        }
    }
}
