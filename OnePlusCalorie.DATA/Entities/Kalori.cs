using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class Kalori
    {
        public int ID { get; set; }

        public int _Kalori { get; set; }

        public int BesinGrami { get; set; }

        public int BesinID { get; set; }

        //Navigation Property 

        public virtual Besin KalorininBesini { get; set; }

        public string BesinKaloriDegeriGoster()
        {
            return $"-Besin Kalori Değerleri-\n\rKalori : {_Kalori} Kcal\n\rBesin Gramı: {BesinGrami} gr";

        }

    }
}
