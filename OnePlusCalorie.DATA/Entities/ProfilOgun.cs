using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.DATA.Entities
{
    public class ProfilOgun
    {
        public int ID { get; set; }

        public int ProfillerID { get; set; }

        public int OgunDetaylariID { get; set; }

        //Navigation Property

        public virtual ProfilBilgisi Profiller { get; set; }

        public virtual OgunDetaylari OgunDetaylari { get; set; }

    }
}
