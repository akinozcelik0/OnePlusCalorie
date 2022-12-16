using Microsoft.EntityFrameworkCore;
using OnePlusCalorie.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DAL.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.; Database = OnePlusCaloriev2Db; integrated security = true;");
        }

        
        //Kullanicilar ve Adminler (Login ve Register)
        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Admin> Adminler { get; set; }


        //Profil Bilgisi
        public DbSet<ProfilBilgisi> ProfilBilgileri { get; set; }


        //BESIN BOLUMU
        public DbSet<Besin> Besinler { get; set; }

        public DbSet<BesinDegeri> BesinDegerleri { get; set; }

        public DbSet<BesinKategori> BesinKategorileri { get; set; }

        public DbSet<Kalori> Kaloriler { get; set; }

        //OGUN BOLUMU

        public DbSet<OgunDetaylari> OgunDetaylar { get; set; }

        //public DbSet<OgunZamani> OgunZamanlari { get; set; }

        public DbSet<BesinOgun> BesinOgunTablosu { get; set; }  

        public DbSet<ProfilOgun> ProfilOgunTablolari { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Admin icin ayri bir config acmak yerine burada gosterdim.
            modelBuilder.Entity<Admin>().HasKey(x => x.ID);

            modelBuilder.Entity<Admin>().Property(x => x.AdminAdi).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Admin>().HasIndex(x => x.AdminAdi).IsUnique();

            modelBuilder.Entity<Admin>().Property(x => x.AdminSifre).HasMaxLength(100).IsRequired();

            //modelBuilder.Entity<OgunDetaylari>().HasOne(ogun => ogun.OgunZamani).WithOne(zaman => zaman.ZamanOgun).HasForeignKey<OgunZamani>(fk => fk.OgunID);

            base.OnModelCreating(modelBuilder);
        }





    }
}
