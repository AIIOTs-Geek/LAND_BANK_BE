using Common.Helper;
using Common.ViewModels;
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
    public class AssetRepository:IAssetRepository
    {
        private readonly IConfiguration _configuration;
        public AssetRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<APIResponse<StatusVm>> GetStatus(string statusType)
        {
            var statusList = new List<StatusVm>();

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                var command = db.GetCommand(db.GetStatus(statusType));
                await db.Connection.OpenAsync();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var statusVm = new StatusVm();

                        if (reader.FieldCount == 1 && reader.GetName(0) == "ErrorMessage")
                        {
                            return ResponseHelper<StatusVm>.CreateErrorRes(new List<string> { "No status found"});
                        }
                        else
                        {
                            statusVm.Id = Convert.ToInt32(reader["Id"]);
                            statusVm.Status = reader["Status"].ToString();
                        }

                        statusList.Add(statusVm);
                    }
                }
            }
    }
}
