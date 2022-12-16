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
    public class BesinConfiguration : IEntityTypeConfiguration<Besin>
    {

        

        public void Configure(EntityTypeBuilder<Besin> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Ad).HasMaxLength(255).IsRequired();

            builder.HasOne(besin => besin.BesininDegerleri).WithOne(deger => deger.DegerBesin).HasForeignKey<BesinDegeri>(fk => fk.BesinID);

            builder.HasOne(besin => besin.Kategori).WithMany(kategori => kategori.KategorininBesinleri).HasForeignKey(fk => fk.KategoriID);

            builder.HasMany(besin => besin.BesinlerOgun).WithOne(ogunBesin => ogunBesin.OgununBesini).HasForeignKey(fk => fk.BesinID);

            builder.HasOne(besin => besin.BesininKalorisi).WithOne(kalori => kalori.KalorininBesini).HasForeignKey<Kalori>(fk => fk.BesinID);

            builder.ToTable("Besinler");
        }
    }
}
