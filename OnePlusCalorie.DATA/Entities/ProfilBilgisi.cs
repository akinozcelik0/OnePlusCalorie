using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class ProfilBilgisi
    {
        public int ID { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int? Yas { get; set; }
        public double? Boy { get; set; }
        public double? Kilo { get; set; }
        public string? Cinsiyet { get; set; }
        public string? YasamTarzi { get; set; } 
        public string? HamilelikDurumu { get; set; }
        public double? VucutKitleEndeksi { get; set; }
        public string? ProfilResmi { get; set; } 

        public DateTime GuncellemeTarihi { get; set; }

        public int KullaniciID { get; set; }

        //navigation property
        public virtual Kullanici Kullanici { get; set; }

        
    }
}
