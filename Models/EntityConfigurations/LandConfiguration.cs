using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models.Land;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models.EntityConfigurations
{
    public class LandConfiguration: IEntityTypeConfiguration<LandMaster>
    {
        public void Configure(EntityTypeBuilder<LandMaster> builder)
        {
            builder.Property(p => p.Area).HasColumnType("decimal(18, 4)");
        }
    }
}
