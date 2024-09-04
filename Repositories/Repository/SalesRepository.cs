using Common.Dtos;
using DataContext.DataClasses;
using Microsoft.Extensions.Configuration;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
