using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class BesinKategori
    {
        public int ID { get; set; }

        public string KategoriAdi { get; set; }

        //Navigation Property 
        public virtual List<Besin> KategorininBesinleri { get; set; }

        
    }
}
