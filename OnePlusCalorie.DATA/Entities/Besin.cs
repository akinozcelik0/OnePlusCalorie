using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class Besin
    {
        public int ID { get; set; }

        public string Ad { get; set; }

        public int KategoriID { get; set; }

        

        


        //Navigation Property

        public virtual BesinKategori Kategori { get; set; }  //One to Many 

        public virtual BesinDegeri BesininDegerleri { get; set; } //One to One 

        public virtual List<BesinOgun> BesinlerOgun { get; set; } //Many to Many  

        public virtual Kalori BesininKalorisi { get; set; } //One to One 

        public  string Goster()
        {
            return $" Besin Adı: {Ad}\n\rKalori: {BesininKalorisi._Kalori}";
        }

        public string BesinGoster()
        {
            return $"- Besin Bilgileri -\n\r Besin Adı:{Ad}\n\r Besin Kategori Numarası: {KategoriID}";
        }


    }
}
