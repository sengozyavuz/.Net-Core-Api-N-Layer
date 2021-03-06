using AssigmentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.Business.Abstract
{
    public interface ITurkishAlphabetCharacterService
    {
        List<TurkishAlphabetCharacter> GetAll();

    }
}
