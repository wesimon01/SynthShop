using Autofac;
using SynthShop.Services;
using SynthShopData.Models;
using SynthShopData.Models.Infrastructure;

namespace SynthShop.Modules
{
    public class ApplicationModule : Module
    {
        private bool useTestData;

        public ApplicationModule(bool useTestData)
        {
            this.useTestData = useTestData;
        }
        protected override void Load(ContainerBuilder builder)
        {
            if (useTestData)
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
            
            //builder.RegisterType<CatalogDBContext>()
            //    .InstancePerLifetimeScope();
            //builder.RegisterType<CatalogDBInitializer>()
            //    .InstancePerLifetimeScope();
            //builder.RegisterType<CatalogItemHiLoGenerator>()
            //    .InstancePerLifetimeScope();
        }
    }
}