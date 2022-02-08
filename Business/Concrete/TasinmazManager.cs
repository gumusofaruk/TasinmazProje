using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TasinmazManager : ITasinmazService
    {
        ITasinmazDal _taşınmazDal;

        public TasinmazManager(ITasinmazDal taşınmazDal)
        {
            _taşınmazDal = taşınmazDal;
        }

        public IResult Add(Tasinmaz tasinmaz)
        {
            if (tasinmaz.TasinmazAdi.Length < 2)
            {
                return new ErrorResult(Messages.TasinmazAdiInvalid);
            }
            _taşınmazDal.Add(tasinmaz);
             
            return new Result(true,Messages.TasinmazAdded);
        }

        public IDataResult<List<Tasinmaz>> GetAll()
        {
            /*if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<Tasinmaz>>(Messages.MaintenanceTime);
            }*/
            return new SuccessDataResult<List<Tasinmaz>>(_taşınmazDal.GetAll(),Messages.TasinmazsListed);
        }

        public IDataResult<List<Tasinmaz>> GetAllByIlId(int id)
        {
            return new SuccessDataResult<List<Tasinmaz>>(_taşınmazDal.GetAll(p => p.IlId == id));
        }

        public IDataResult<Tasinmaz> GetById(int id)
        {
            return new SuccessDataResult<Tasinmaz>(_taşınmazDal.Get(p=>p.TasinmazId==id));
        }

        public IDataResult<List<TasinmazDetailDto>> GetTasinmazDetails()
        {
            return new SuccessDataResult<List<TasinmazDetailDto>>(_taşınmazDal.GetTasinmazDetails());
        }
    }
}
