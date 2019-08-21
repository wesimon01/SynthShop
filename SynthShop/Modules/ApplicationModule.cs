using Autofac;
using SynthShop.Services;
using SynthShopData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SynthShop.Modules
{
    public class ApplicationModule : Module
    {
        private bool useMockData;

        public ApplicationModule(bool useMockData)
        {
            this.useMockData = useMockData;
        }
        protected override void Load(ContainerBuilder builder)
        {
            if (useMockData)
            {
                builder.RegisterType<CatalogServiceTest>()
                    .As<ICatalogService>()
                    .SingleInstance();
            }
            else
            {
                builder.RegisterType<CatalogService>()
                    .As<ICatalogService>()
                    .InstancePerLifetimeScope();                
            }
            
            builder.RegisterType<CatalogDBContext>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CatalogDBInitializer>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CatalogItemHiLoGenerator>()
                .InstancePerLifetimeScope();
        }
    }
}