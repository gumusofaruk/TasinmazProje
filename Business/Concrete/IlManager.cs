using Business.Abstract;
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
        public List<Il> GetAll()
        {
            return _ilDal.GetAll();
        }

        public Il GetById(int ilId)
        {
            return _ilDal.Get(c=>c.IlId == ilId);
        }

    }
}
