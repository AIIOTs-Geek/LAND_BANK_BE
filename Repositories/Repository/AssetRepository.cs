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
    }
}
