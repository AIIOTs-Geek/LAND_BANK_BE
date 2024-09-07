using Api.Controllers;
using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.IService;

namespace LandingAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LandController : BaseController
    {
        private readonly ILandService _landService;
        public LandController(ILandService landService)
        {
            _landService = landService;
        }
        [HttpGet]
        public async Task<IActionResult> GetLandDetails(int landId, string? deptt)
        {
            return Response(await _landService.GetLandDetails(landId, deptt));
        }

        [HttpGet]
        public async Task<IActionResult> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, int? IsWlt)
        {
            return Response(await _landService.GetLandsByAssetId(assetId, searchText, cityId, districtId, userId, landUseId, businessPlanId, IsWlt));
        }        
        [HttpPost]
        public async Task<IActionResult> UpdateLandOverview(UpdateLandDto landDto)
        {
            return Response(await _landService.UpdateLand(landDto));
        }
        [HttpPost]
        public async Task<IActionResult> UpsertBuyerDetails(AddBuyerDto buyerDto)
        {
            return Response(await _landService.UpdateBuyerDetails(buyerDto));
        }

        [HttpPost]
        public async Task<IActionResult> UpsertFinance(UpsertFinanceDto upsertFinance)
        {
            return Response(await _landService.UpsertFinance(upsertFinance));
        }
        [HttpPost]
        public async Task<IActionResult> UpsertTitleDeed(UpsertTitleDeedDto upsertTitleDeed)
        {
            return Response(await _landService.UpsertTitleDeed(upsertTitleDeed));
        }
    }
}
