using AssigmentAPI.Business.Abstract;
using AssigmentAPI.Business.Contract.Managers;
using AssigmentAPI.DataAccess.Abstract;
using AssigmentAPI.DataAccess.Concrate.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace AssigmentAPI.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrimeNumberService>().To<PrimeNumberManager>().InSingletonScope();
            Bind<IPrimeNumberDal>().To<EfPrimeNumberDal>().InSingletonScope();

            Bind<ITurkishAlphabetCharacterService>().To<TurkishAlphabetCharacterManager>();
            Bind<ITurkishAlphabetCharacterDal>().To<EFTurkishAlphabetCharacterDal>();

            Bind<DbContext>().To<AssigmentContext>();
        }

    }
}
