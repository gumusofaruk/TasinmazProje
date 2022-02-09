using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IlManager : IIlService
    {
        IIlDal _ilDal;
        public IlManager(IIlDal ilDal)
        {
            _ilDal = ilDal; 
        }
        public IDataResult<List<Il>> GetAll()
        {
            return new SuccessDataResult<List<Il>>(_ilDal.GetAll());
        }

        public IDataResult<Il> GetById(int ilId)
        {
            return new SuccessDataResult<Il>(_ilDal.Get(c=>c.IlId == ilId));
        }

    }
}
