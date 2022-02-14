using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITasinmazService
    {
        IDataResult<List<Tasinmaz>> GetAll();
        IDataResult<List<Tasinmaz>> GetAllByIlId(int id);
        IDataResult<List<TasinmazDetailDto>> GetTasinmazDetails();
        IDataResult<Tasinmaz> GetById(int id);
        IResult Add(Tasinmaz tasinmaz);
        IResult Update(Tasinmaz tasinmaz);
        IResult AddTransactionalTest(Tasinmaz tasinmaz);    
        IResult Delete(Tasinmaz tasinmaz);
    }
}
