using AssigmentAPI.Business.Abstract;
using AssigmentAPI.DataAccess.Abstract;
using AssigmentAPI.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.Business.Contract.Managers
{
    public class PrimeNumberManager : IPrimeNumberService
    {
        private IPrimeNumberDal _primeNumberDal;
        private IMapper _mapper;

        public PrimeNumberManager(IPrimeNumberDal primeNumberDal, IMapper mapper)
        {
            _primeNumberDal = primeNumberDal;
            _mapper = mapper;
        }

        public List<PrimeNumber> GetAll()
        {
            return CreatePrimeNumber();
        }

        int id = 1;
        List<PrimeNumber> pn = new List<PrimeNumber>();
        Random rnd = new Random();
        PrimeNumber primeNumber = new PrimeNumber();
        private List<PrimeNumber> CreatePrimeNumber()
        {
            primeNumber.Id = id;
            primeNumber.Number = rnd.Next(-128, 127);
            pn.Add(primeNumber);
            id++;
            return pn;
        }
    }
}
