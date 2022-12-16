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
    public class BesinKategoriConfiguration : IEntityTypeConfiguration<BesinKategori>
    {
        public void Configure(EntityTypeBuilder<BesinKategori> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.KategoriAdi).HasMaxLength(100).IsRequired();

            builder.ToTable("BesinKategorileri");
        }
    }
}
