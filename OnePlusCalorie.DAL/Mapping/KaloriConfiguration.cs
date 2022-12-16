using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnePlusCalorie.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DAL.Mapping
{
    public class KaloriConfiguration : IEntityTypeConfiguration<Kalori>
    {
        public void Configure(EntityTypeBuilder<Kalori> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x._Kalori).HasColumnType("Decimal(18,2)").IsRequired();

            builder.Property(x => x.BesinGrami).HasColumnType("Decimal(18,2)").IsRequired();


        }
    }
}
