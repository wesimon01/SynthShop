using Autofac;
using Autofac.Integration.Web;
using log4net;
using SynthShop.Modules;
using SynthShopData.Models;
using SynthShopData.Models.Infrastructure;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Diagnostics;
using System.Reflection;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace SynthShop
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static IContainerProvider _containerProvider;
        IContainer container;

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigContainer();
            ConfigDataBase();
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            HttpContext.Current.Session["MachineName"] = Environment.MachineName;
            HttpContext.Current.Session["SessionStartTime"] = DateTime.Now;
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            LogicalThreadContext.Properties["activityId"] = new ActivityIdHelper();
            LogicalThreadContext.Properties["requestinfo"] = new WebRequestInfo();

            _log.Debug("Application_BeginRequest");
        }
        private void ConfigContainer()
        {
            var builder = new ContainerBuilder();
            var testData = bool.Parse(ConfigurationManager.AppSettings["UseTestData"]);
            builder.RegisterModule(new ApplicationModule(testData));
            container = builder.Build();
            _containerProvider = new ContainerProvider(container);
        }
        private void ConfigDataBase()
        {
            var testData = bool.Parse(ConfigurationManager.AppSettings["UseTestData"]);

            if (!testData)
            {
                Database.SetInitializer<CatalogDBContext>(container.Resolve<CatalogDBInitializer>());
            }
        }
    }

    public class ActivityIdHelper 
    {
        public override string ToString()
        {
            if (Trace.CorrelationManager.ActivityId == Guid.Empty)
            {
                Trace.CorrelationManager.ActivityId = Guid.NewGuid();
            }
            return Trace.CorrelationManager.ActivityId.ToString();
        }
    }
    public class WebRequestInfo 
    {
        public override string ToString()
        {
            return HttpContext.Current?.Request?.RawUrl + ", " + HttpContext.Current?.Request?.UserAgent;
        }
    }


}