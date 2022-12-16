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
    public class BesinDegeriConfiguration : IEntityTypeConfiguration<BesinDegeri>
    {

        
        public void Configure(EntityTypeBuilder<BesinDegeri> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Gram).HasColumnType("int").IsRequired();

            builder.Property(x => x.Karbonhidrat).HasColumnType("int").IsRequired();

            builder.Property(x => x.Yag).HasColumnType("int").IsRequired();

            builder.Property(x => x.Protein).HasColumnType("int").IsRequired();

            builder.Property(x => x.Lif).HasColumnType("int").IsRequired(false);

            builder.Property(x => x.Kolestrol).HasColumnType("int").IsRequired(false);

            builder.Property(x => x.Sodyum).HasColumnType("int").IsRequired(false);

            builder.Property(x => x.Potasyum).HasColumnType("int").IsRequired(false);

            builder.Property(x => x.Kalsiyum).HasColumnType("int").IsRequired(false);

            builder.ToTable("BesinDegerleri");
        }
    }
}
