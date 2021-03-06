using AssigmentAPI.Core.DataAccess.EntityFramework;
using AssigmentAPI.DataAccess.Abstract;
using AssigmentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.DataAccess.Concrate.EntityFramework
{
    public class EFTurkishAlphabetCharacterDal : EfEntityRepositoryBase<TurkishAlphabetCharacter, AssigmentContext>, ITurkishAlphabetCharacterDal
    {
    }
}
