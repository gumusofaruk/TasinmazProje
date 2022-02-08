using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTasinmazDal : EfEntityRepositoryBase<Tasinmaz, TasinmazContext>, ITasinmazDal
    {
        public List<TasinmazDetailDto> GetTasinmazDetails()
        {
            using (TasinmazContext context =new TasinmazContext())
            {
                var result = from p in context.Tasinmazs
                             join c in context.Ils
                             on p.TasinmazId equals c.IlId
                             select new TasinmazDetailDto
                             {
                                 TasinmazId = p.TasinmazId,
                                 TasinmazAdi = p.TasinmazAdi,
                                 IlAdi = c.IlAdi
                             };
                return result.ToList();
            }
        }
    }
}
