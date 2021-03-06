using AssigmentAPI.Business.Abstract;
using AssigmentAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssigmentAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurkishAlphabetCharactersController : ControllerBase
    {
        private ITurkishAlphabetCharacterService _turkishAlphabetCharacterService;

        public TurkishAlphabetCharactersController(ITurkishAlphabetCharacterService turkishAlphabetCharacterService)
        {
            _turkishAlphabetCharacterService = turkishAlphabetCharacterService;
        }


        // GET: api/<PrimeNumbersController>
        [HttpGet]
        public List<TurkishAlphabetCharacter> Get()
        {
            return _turkishAlphabetCharacterService.GetAll();
        }
    }
}
