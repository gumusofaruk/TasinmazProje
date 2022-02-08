using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryTasinmazDal : ITasinmazDal
    {
        List<Tasinmaz> _tasinmaz;
        public InMemoryTasinmazDal()
        {
            _tasinmaz = new List<Tasinmaz>
                {
                    new Tasinmaz{IlId=1,IlceId=1,TasinmazAdi="Arsa",TasinmazId=1},
                    new Tasinmaz{IlId=2,IlceId=2,TasinmazAdi="Tarla",TasinmazId=2},
                    new Tasinmaz{IlId=2,IlceId=3,TasinmazAdi="Bağ",TasinmazId=3},
                    new Tasinmaz{IlId=1,IlceId=3,TasinmazAdi="Bahçe",TasinmazId=4},
                    new Tasinmaz{IlId=2,IlceId=2,TasinmazAdi="Ev",TasinmazId=5}
                };
        }
        public void Add(Tasinmaz tasinmaz)
        {
            _tasinmaz.Add(tasinmaz);
        }

        public void Delete(Tasinmaz tasinmaz)
        {
            Tasinmaz tasinmazToDelete = _tasinmaz.SingleOrDefault(p=>p.TasinmazId==tasinmaz.TasinmazId);
            _tasinmaz.Remove(tasinmazToDelete);
        }

        public Tasinmaz Get(Expression<Func<Tasinmaz, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Tasinmaz> GetAll()
        {
            return _tasinmaz;  
        }

        public List<Tasinmaz> GetAll(Expression<Func<Tasinmaz, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Tasinmaz> GetAllByIlce(int ilceAdi)
        {
           return _tasinmaz.Where(p=>p.IlceId==ilceAdi).ToList();
        }

        public List<TasinmazDetailDto> GetTasinmazDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Tasinmaz tasinmaz)
        {
            Tasinmaz taşınmazToUpdate = _tasinmaz.SingleOrDefault(p => p.TasinmazId == tasinmaz.TasinmazId);
            taşınmazToUpdate.TasinmazAdi = tasinmaz.TasinmazAdi;
            taşınmazToUpdate.TasinmazId = tasinmaz.TasinmazId;
            taşınmazToUpdate.IlId = tasinmaz.IlId;
            taşınmazToUpdate.IlceId = tasinmaz.IlceId;

        }
    }
}
