using Microsoft.EntityFrameworkCore;
using Models.EntityConfigurations;
using Models.Models.Asset;
using Models.Models.BusinessPlan;
using Models.Models.Land;
using Models.Models.Region;
using Models.Models.UserDetails;
using Models.Models.WorkFlow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    public class LBDbContext:DbContext
    {
        public LBDbContext(DbContextOptions<LBDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new LandConfiguration());
        }
        //public DbSet<AssetMaster> AssetMaster { get; set; }
        //public DbSet<BusinessPlanMaster> BusinessPlanMaster { get; set; }
        //public DbSet<BusinessPlanStatusMaster> BusinessPlanStatusMaster { get; set; }
        //public DbSet<CityMaster> CityMaster { get; set; }
        //public DbSet<DistrictMaster> DistrictMaster { get; set; }
        //public DbSet<RegionMaster> RegionMaster { get; set; }
        //public DbSet<LandMaster> LandMaster { get; set; }
        //public DbSet<LandStatusMaster> LandStatusMaster { get; set; }
        //public DbSet<LandTypeMaster> LandTypeMaster { get; set; }
        //public DbSet<LandUseMaster> LandUseMaster { get; set; }
        //public DbSet<SubAssetMaster> SubAssetMaster { get; set; }
        //public DbSet<WF_ProcessMaster> WF_ProcessMaster { get; set; }
        //public DbSet<WF_ActionMaster> WF_ActionMaster { get; set; }
        //public DbSet<WF_ControlMaster> WF_ControlMaster { get; set; }
        //public DbSet<WF_InstanceMaster> WF_InstanceMaster { get; set; }
        //public DbSet<WF_StageMaster> WF_StageMaster { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
