using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class BesinDegeri
    {
        public int ID { get; set; }

        public int? Gram { get; set; }

        public int? Karbonhidrat { get; set; }

        public int? Yag { get; set; }

        public int? Protein { get; set; }

        public int? Lif { get; set; }

        public int? Kolestrol { get; set; }

        public int? Sodyum { get; set; }

        public int? Potasyum { get; set; }

        public int? Kalsiyum { get; set; }

        public int BesinID { get; set; }

        //Navigation Property

        public virtual Besin DegerBesin { get; set; }   
        

        public string BesinDegerleriniGoster()
        {
            return $"-Besin Değerleri-\n\rGramaj : {Gram}\n\rKarbonhidrat: {Karbonhidrat}\n\rYağ: {Yag}\n\rProtein: {Protein}\n\rLif: {Lif}\n\rKolestrol: {Kolestrol}\n\rSodyum: {Sodyum}\n\rPotasyum: {Potasyum}\n\rKalsiyum: {Kalsiyum}";

        }


    }
}
