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
    public class OgunDetaylariConfiguration : IEntityTypeConfiguration<OgunDetaylari>
    {
        
        public void Configure(EntityTypeBuilder<OgunDetaylari> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.BesinID).IsRequired(false);

            //builder.HasMany(ogun => ogun.OgunBesinleri).WithOne(besınOgun => besınOgun.BesininOgunu).HasForeignKey(fk => fk.OgunID);

            //builder.Property(x => x.BesinIkiID).IsRequired(false);

            //builder.Property(x => x.BesinUcID).IsRequired(false);

            //builder.Property(x => x.BesinDortID).IsRequired(false);

            //builder.Property(x => x.BesinBesID).IsRequired(false);

            //builder.Property(x => x.BesinAltiID).IsRequired(false);

            //builder.Property(x => x.BesinYediID).IsRequired(false);

            //builder.Property(x => x.BesinSekizID).IsRequired(false);

            //builder.Property(x => x.BesinDokuzID).IsRequired(false);

            //builder.Property(x => x.BesinOnID).IsRequired(false);

            //builder.Property(x => x.ToplamGram).IsRequired(false).HasColumnType("decimal(18,2)");

            //builder.Property(x => x.ToplamKalori).IsRequired(false).HasColumnType("decimal(18,2)");

            //builder.HasOne(ogunDet => ogunDet.OgunZamani).WithOne(zaman => zaman.ZamanOgun).HasForeignKey<OgunZamani>(fk => fk.OgunID); //One to One*/

            builder.ToTable("OgunDetaylar");

            
        }
    }
}
