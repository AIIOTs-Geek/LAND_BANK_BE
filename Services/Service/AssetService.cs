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
    public class AssetService:IAssetService
    {
        private readonly IAssetRepository _assetRepository;
        public AssetService(IAssetRepository assetRepository)
        {
             _assetRepository = assetRepository;
        }       
        public async Task<APIResponse<List<StatusVm>>> GetStatus(string statusType)
        {
            var statusVmList = new List<StatusVm>();
            var statusList =  await _assetRepository.GetStatus(statusType);
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
    }
}
