using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string TasinmazAdded = "Taşınmaz eklendi";
        public static string TasinmazAdiInvalid = "Taşınmaz adı geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string TasinmazsListed="Taşınmazlar Listelendi";
        public static string TasinmazCountofIlError="Bir Ilde en fazla 10 tasinmaz olabilir";
        internal static string TasinmazNameAlreadyExists="Bu isimde başka taşınmaz var";
        internal static string CategoryLimitExceded="Limit aşıldığı için taşınmaz eklenemiyor";
    }
}
