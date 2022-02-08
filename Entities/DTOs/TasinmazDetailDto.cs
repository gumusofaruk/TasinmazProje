using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TasinmazDetailDto:IDto 
    {
        public int TasinmazId { get; set; }
        public string TasinmazAdi { get; set; }
        public string IlAdi { get; set; }
        
    }
}
