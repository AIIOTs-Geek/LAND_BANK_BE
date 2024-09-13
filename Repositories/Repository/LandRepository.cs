using Common.Dtos;
using Common.ViewModels;
using DataContext.DataClasses;
using Microsoft.Extensions.Configuration;
using Models.Models.UserDetails;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public async Task<GetLandDetailForViewerResult> GetLandDetailsForViewer(int landId, string? deptt)
        {
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = db.GetLandDetailForViewer(landId, deptt, userId).SingleOrDefault();
                if (result == null)
                {
                    return null;
                }

                return result;
            }
        }
        public async Task<List<GetLandByAssetIdResult>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? ownerId, int? landUseId, int? businessPlanId, int? IsWlt,int pageno,int pagesize)
        {
            var result = new List<GetLandByAssetIdResult>();
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetLandByAssetId(assetId, searchText, cityId, districtId, ownerId, landUseId, businessPlanId, IsWlt, userId,pageno,pagesize).ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }
        public async Task<int> Updateland(UpdateLandDto landDto)
        {
            int? userId = null;
            int result;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.UpdateLandOverview(landDto.LandId, userId, landDto.LandInformation, landDto.DistrictId, landDto.Area, landDto.SubAssetId, landDto.Location, landDto.MapUrl, landDto.BusinessPlanId, landDto.BusinessPlanDetailedId, landDto.BusinessPlanStatusId, landDto.LandStatusId, landDto.LandUseId, landDto.LandTypeId, landDto.WltStatus, landDto.MunHandingOver, landDto.MasterPlan, landDto.InfraApproval, landDto.InfraContraction);

                if (result != 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        public async Task<int> UpdateBuyerDetails(AddBuyerDto buyerDto)
        {
            int? userId = null;

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {

                var result = db.UpsertBuyerDetails(userId, buyerDto.Id, buyerDto.BuyerId, buyerDto.BuyerName, buyerDto.CompanyId, buyerDto.BuyerEmail, buyerDto.BuyerMobile);

                if (result == null)
                {
                    return 0;
                }
                //int resultCode=0;
                //if (result != null)
                //{

                //    resultCode = Convert.ToInt32(result);
                //}

                return result;
            }

        }

        public async Task<int> UpsertFinance(UpsertFinanceDto upsertFinance)
        {
            int? userId = null;          

           

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {

                var result = db.UpsertFinance(
                    upsertFinance.LandId,
                    upsertFinance.BookValue,
                    upsertFinance.CostPer,
                    upsertFinance.LatestValue,                
                    userId,                    
                    upsertFinance.ZakatPayment,
                    upsertFinance.ZakatImplication
                );
                if (result == 1)
                {
                    return 1;
                }

                return 0;
            }
        }
        public async Task<int> UpsertTitleDeed(UpsertTitleDeedDto upsertTitleDeed)
        {
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {

                var result = db.UpsertTitleDeed(userId,
                    upsertTitleDeed.LandId,upsertTitleDeed.TitleDeedId, upsertTitleDeed.DeedNumber,upsertTitleDeed.DeedDate,upsertTitleDeed.DeedType,upsertTitleDeed.DeedStatus,upsertTitleDeed.DeedUrl,upsertTitleDeed.DeedOwner,upsertTitleDeed.DeedSequence
                );
                if (result != 0)
                {
                    return 1;
                }

                return 0;
            }
        }
        public async Task<int> LandUpdateAction(LandUpdateActionDto actionDto)
        {
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {

                var result = db.LandUpdateAction(userId, actionDto.LandId, actionDto.Action);
                if (result != 0)
                {
                    return 1;
                }

                return 0;
            }
        }
    }
}
