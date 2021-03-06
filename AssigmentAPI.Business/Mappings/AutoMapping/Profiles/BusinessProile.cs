using AssigmentAPI.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.Business.Mappings.AutoMapping.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<PrimeNumber, PrimeNumber>();
            CreateMap<TurkishAlphabetCharacter, TurkishAlphabetCharacter>();
        }

    }
}
