using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using OnePlusCalorie.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DAL.Mapping
{
    public class ProfilBilgisiConfiguration : IEntityTypeConfiguration<ProfilBilgisi>
    {
        //public int ID { get; set; }
        //public string Ad { get; set; }
        //public string Soyad { get; set; }
        //public int Yas { get; set; }
        //public double Boy { get; set; }
        //public double Kilo { get; set; }
        //public bool Cinsiyet { get; set; }
        //public string YasamTarzi { get; set; }
        //public double? VucutKitleEndeksi { get; set; }

        //public DateTime GuncellemeTarihi { get; set; }

        ////navigation property
        //public virtual Kullanici Kullanici { get; set; }

        //public int KullaniciID { get; set; }
        public void Configure(EntityTypeBuilder<ProfilBilgisi> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Ad).HasMaxLength(100).IsRequired(false);

            builder.Property(x => x.Soyad).HasMaxLength(100).IsRequired(false);

            builder.Property(x => x.Yas).HasColumnType("int").IsRequired(false);

            builder.Property(x => x.Boy).HasColumnType("decimal(18,2)").IsRequired(false);

            builder.Property(x => x.Kilo).HasColumnType("decimal(18,2)").IsRequired(false);

            builder.Property(x => x.Cinsiyet).HasColumnType("nvarchar(100)").IsRequired(false);

            builder.Property(x => x.YasamTarzi).HasColumnType("nvarchar(255)").IsRequired(false);

            builder.Property(x => x.VucutKitleEndeksi).HasColumnType("decimal(18,2)").IsRequired(false);

            

            builder.ToTable("ProfilBilgileri");
        }
    }
}
