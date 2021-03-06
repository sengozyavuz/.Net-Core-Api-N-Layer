using AssigmentAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.Entities
{
    public class TurkishAlphabetCharacter : IEntity
    {
        public  int Id { get; set; }
        public  string Character { get; set; }
    }
}
