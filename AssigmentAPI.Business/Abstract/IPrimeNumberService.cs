using AssigmentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.Business.Abstract
{
    public interface IPrimeNumberService
    {
        
        List<PrimeNumber> GetAll();
    }
}
