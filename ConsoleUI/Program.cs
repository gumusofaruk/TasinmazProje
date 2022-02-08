using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            TasinmazTest();
            //IlTest();
        }

        private static void IlTest()
        {
            IlManager ilManager = new IlManager(new EfIlDal());

            foreach (var il in ilManager.GetAll())
            {
                Console.WriteLine(il.IlAdi);
            }
        }

        private static void TasinmazTest()
        {
            TasinmazManager tasinmazManager = new TasinmazManager(new EfTasinmazDal());

            var result =tasinmazManager.GetTasinmazDetails();
            if (result.Success)
            {
                foreach (var tasinmaz in result.Data)
                {
                    Console.WriteLine(tasinmaz.TasinmazAdi + "/" + tasinmaz.IlAdi);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
