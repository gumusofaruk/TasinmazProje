using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IlsController : ControllerBase
    {
        private IIlService _ilService;

        public IlsController(IIlService ilService)
        {
            _ilService = ilService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _ilService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }

    
}
