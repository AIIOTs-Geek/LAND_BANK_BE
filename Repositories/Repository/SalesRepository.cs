using Common.Dtos;
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
    public class SalesRepository:ISalesRepository
    {
        private readonly IConfiguration _configuration;
        public SalesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<AddBuyerDetailsResult> AddBuyerDetails(AddBuyerDto buyerDto)
        {
            var result = new AddBuyerDetailsResult();
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.AddBuyerDetails(userId, buyerDto.BuyerId, buyerDto.BuyerName, buyerDto.CompanyId, buyerDto.BuyerEmail, buyerDto.BuyerMobile).SingleOrDefault();

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
        public async Task<int> UpdateLandCoordinates(UpdateLandCoordinateDto landCoordinateDto)
        {
            int? userId = null;
            int result;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.AddORUpdateLandCoordinates(userId, landCoordinateDto.LandId,landCoordinateDto.MapId,landCoordinateDto.Latitude,landCoordinateDto.Longitude,landCoordinateDto.LandShape);

                if (result != 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        public async Task<GetLandCoordinatesResult> GetLandCoordinates(int landId)
        {
            var result = new GetLandCoordinatesResult();
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetLandCoordinates(userId, landId).SingleOrDefault();

                if (result == null)
                {
                    return null;
                }
            }
            return result;
        }
    }
}
