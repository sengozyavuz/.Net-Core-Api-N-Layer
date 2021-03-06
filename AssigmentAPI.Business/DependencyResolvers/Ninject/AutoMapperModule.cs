using AutoMapper;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentAPI.Business.DependencyResolvers.Ninject
{
    class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToConstant(CreateConfiguraiton().CreateMapper()).InSingletonScope();
        }

        private MapperConfiguration CreateConfiguraiton()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles((IEnumerable<Profile>)GetType().Assembly);
            });

            return config;
        }
    }
}
