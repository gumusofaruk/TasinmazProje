using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TasinmazManager : ITasinmazService
    {
        ITasinmazDal _tasinmazDal;
        IIlService _ilService;
       

        public TasinmazManager(ITasinmazDal tasinmazDal,IIlService ilService)
        {
            _tasinmazDal = tasinmazDal;
            _ilService = ilService;
           
        }

        [ValidationAspect(typeof(TasinmazValidator))]
        public IResult Add(Tasinmaz tasinmaz)
        {
            IResult result =BusinessRules.Run(CheckIfTasinmazNameExists(tasinmaz.TasinmazAdi), CheckIfTasinmazCountOfIlCorrect(tasinmaz.IlId),
                CheckIfCategoryLimitExceded());
            if (result != null)
            {
                return result;
            }
            _tasinmazDal.Add(tasinmaz);

            return new Result(true, Messages.TasinmazAdded);
            

        }

        public IDataResult<List<Tasinmaz>> GetAll()
        {
            if (DateTime.Now.Hour == 16)
            {
                return new ErrorDataResult<List<Tasinmaz>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Tasinmaz>>(_tasinmazDal.GetAll(),Messages.TasinmazsListed);
        }

        public IDataResult<List<Tasinmaz>> GetAllByIlId(int id)
        {
            return new SuccessDataResult<List<Tasinmaz>>(_tasinmazDal.GetAll(p => p.IlId == id));
        }

        public IDataResult<Tasinmaz> GetById(int id)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(p=>p.TasinmazId==id));
        }

        public IDataResult<List<TasinmazDetailDto>> GetTasinmazDetails()
        {
            return new SuccessDataResult<List<TasinmazDetailDto>>(_tasinmazDal.GetTasinmazDetails());
        }

        public IResult Update(Tasinmaz Tasinmaz)
        {
            throw new NotImplementedException();
        }
        private IResult CheckIfTasinmazCountOfIlCorrect(int ilId)
        {
            var result = _tasinmazDal.GetAll(p => p.IlId == ilId).Count();
            if (result >= 10)
            {
                return new ErrorResult(Messages.TasinmazCountofIlError);

            }
            return new SuccessResult();

        }
        private IResult CheckIfTasinmazNameExists(string tasinmazAdi)
        {
            var result = _tasinmazDal.GetAll(p => p.TasinmazAdi == tasinmazAdi).Any();
            if (result)
            {
                return new ErrorResult(Messages.TasinmazNameAlreadyExists);

            }
            return new SuccessResult();

        }
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _ilService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);

            }
            return new SuccessResult();
        }
    }
}
