
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Mahalle:IEntity
    {
        public int MahalleId { get; set; }
        public string MahalleAdi { get; set; }    
    }
}
