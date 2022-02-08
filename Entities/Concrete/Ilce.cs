using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ilce:IEntity
    {
        public string IlceAdi { get; set; }    
        public int IlceId { get; set; } 
    }
}
