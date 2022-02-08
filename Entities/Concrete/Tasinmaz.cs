using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tasinmaz:IEntity

    {
        public int TasinmazId { get; set; }
        public string TasinmazAdi { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        /*public string MahalleAdi { get; set; }       
        public string Ada { get; set; }
        public string Parsel { get; set; }
        public string Nitelik { get; set; }
        public int Coordinates { get; set; }*/
    }
}
