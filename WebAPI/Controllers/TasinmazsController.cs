using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasinmazsController : ControllerBase
    {
        ITasinmazService _tasinmazService;

        public TasinmazsController(ITasinmazService tasinmazService)
        {
            _tasinmazService = tasinmazService;
        }

        [HttpGet]
        public List<Tasinmaz> Get()
        {

            var result =_tasinmazService.GetAll();
            return result.Data;

            
        }
    }
}
