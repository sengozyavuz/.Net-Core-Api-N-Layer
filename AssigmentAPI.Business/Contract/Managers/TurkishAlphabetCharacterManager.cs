using AssigmentAPI.Business.Abstract;
using AssigmentAPI.DataAccess.Abstract;
using AssigmentAPI.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssigmentAPI.Business.Contract.Managers
{
    public class TurkishAlphabetCharacterManager : ITurkishAlphabetCharacterService
    {
        private ITurkishAlphabetCharacterDal _turkishAlphabetCharacterDal;
        private IMapper _mapper;

        public TurkishAlphabetCharacterManager(ITurkishAlphabetCharacterDal turkishAlphabetCharacterDal, IMapper mapper)
        {
            _turkishAlphabetCharacterDal = turkishAlphabetCharacterDal;
            _mapper = mapper;
        }

        public List<TurkishAlphabetCharacter> GetAll()
        {
            return GenerateTurkishAlphabetCharacter();
        }



        int id = 1;
        List<TurkishAlphabetCharacter> tac = new List<TurkishAlphabetCharacter>();
        Random rnd = new Random();
        TurkishAlphabetCharacter turkishAlphabetCharacter = new TurkishAlphabetCharacter();
        const string chars = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        private List<TurkishAlphabetCharacter> GenerateTurkishAlphabetCharacter()
        {
            turkishAlphabetCharacter.Id = id;
            turkishAlphabetCharacter.Character = new string(Enumerable.Repeat(chars, 1)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
            tac.Add(turkishAlphabetCharacter);
            id++;
            return tac;
        }

    }
}
