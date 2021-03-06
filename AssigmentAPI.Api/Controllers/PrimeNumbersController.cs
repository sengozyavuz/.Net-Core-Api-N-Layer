using AssigmentAPI.Business.Abstract;
using AssigmentAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssigmentAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeNumbersController : ControllerBase
    {

        private IPrimeNumberService _primeNumberService;

        public PrimeNumbersController(IPrimeNumberService primeNumberService)
        {
            _primeNumberService = primeNumberService;
        }


        // GET: api/<PrimeNumbersController>
        [HttpGet]
        public List<PrimeNumber> Get()
        {
            return _primeNumberService.GetAll(); 
        }
    }
}
