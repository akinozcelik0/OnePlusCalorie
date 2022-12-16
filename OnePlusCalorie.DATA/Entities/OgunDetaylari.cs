using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class OgunDetaylari
    {
        public int ID { get; set; }

        public int BesinID { get; set; }

        public DateTime EklenmeZamani { get; set; }

        public string OgunAdi { get; set; }

        ////Bir içerisindeki besinler on adet ile sınırlandırılmıştır. 
        //[AllowNull]
        //public int? BesinBirID { get; set; } 
        //[AllowNull]
        //public int? BesinIkiID { get; set; }
        //[AllowNull]
        //public int? BesinUcID { get; set; }
        //[AllowNull]
        //public int? BesinDortID { get; set; }
        //[AllowNull]
        //public int? BesinBesID { get; set; }
        //[AllowNull]
        //public int? BesinAltiID { get; set; }
        //[AllowNull]
        //public int? BesinYediID { get; set; }
        //[AllowNull]
        //public int? BesinSekizID { get; set; }
        //[AllowNull]
        //public int? BesinDokuzID { get; set; }
        //[AllowNull]
        //public int? BesinOnID { get; set; }

        //[AllowNull]
        //public int? ToplamGram { get; set; }

        //[AllowNull]
        //public int? ToplamKalori { get; set; }

        //Navigation Property

        

        public virtual List<BesinOgun> OgunBesinleri { get; set; } // Many to Many 

        //public virtual OgunZamani OgunZamani { get; set; }  //One to One 



    }
}
