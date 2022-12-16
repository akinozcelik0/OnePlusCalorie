using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnePlusCalorie.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DAL.Mapping
{
    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {

        

        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasIndex(x => new {x.Email, x.Telefon, x.KullaniciAdi}).IsUnique();

            builder.Property(x => x.Adi).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Soyad).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(500).IsRequired();

            builder.Property(x => x.Telefon).HasMaxLength(20).IsRequired();

            builder.Property(x => x.Sifre).HasMaxLength(500).IsRequired();

            builder.Property(x => x.UyelikTarihi).HasColumnType("datetime2");

            builder.Property(x => x.GuncellemeTarihi).HasColumnType("datetime2");

            builder.HasOne(kullanici => kullanici.ProfilBilgisi).WithOne(profBilgi => profBilgi.Kullanici).HasForeignKey<ProfilBilgisi>(fk => fk.KullaniciID);

            builder.ToTable("Kullanicilar");

            
        }
    }
}
