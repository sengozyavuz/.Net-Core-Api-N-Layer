using AssigmentAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.Entities
{
    public class PrimeNumber : IEntity
    {
        public  int Id { get; set; }
        public int Number { get; set; }
    }
}
