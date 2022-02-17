using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;

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

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            Thread.Sleep(1000);

            var result =_tasinmazService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);  
        }
        [HttpPost("add")]
        public IActionResult Add(Tasinmaz tasinmaz)
        {
            var result =_tasinmazService.Add(tasinmaz);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id )
        {

            var result = _tasinmazService.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getallbyilid")]
        public IActionResult GetAllByIlId(int ilId)
        {

            var result = _tasinmazService.GetAllByIlId(ilId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
