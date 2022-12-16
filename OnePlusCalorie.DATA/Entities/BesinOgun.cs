using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class BesinOgun
    {
        public int ID { get; set; }

        public int BesinID { get; set; }

        public int BesininOgunuID { get; set; }

        //Navigation Property

        public virtual Besin OgununBesini { get; set; }

        public virtual OgunDetaylari BesininOgunu { get; set; }
    }
}
