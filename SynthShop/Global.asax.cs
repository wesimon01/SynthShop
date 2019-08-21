using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using Autofac.Integration.Web;
using log4net;
using System.Configuration;
using System.Diagnostics;
using System.Data.Entity;
using SynthShop.Modules;

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

        protected void Session_Start(Object sender, EventArgs e)
        {
            HttpContext.Current.Session["MachineName"] = Environment.MachineName;
            HttpContext.Current.Session["SessionStartTime"] = DateTime.Now;
        }
        private void ConfigContainer()
        {
            var builder = new ContainerBuilder();
            var mockData = bool.Parse(ConfigurationManager.AppSettings["UseMockData"]);
            builder.RegisterModule(new ApplicationModule(mockData));
            container = builder.Build();
        }
        private void ConfigDataBase()
        {
            var mockData = bool.Parse(ConfigurationManager.AppSettings["UseMockData"]);

            if (!mockData)
            {
                Database.SetInitializer<CatalogDBContext>(container.Resolve<CatalogDBInitializer>());
            }
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            LogicalThreadContext.Properties["activityId"] = new ActivityIdHelper();
            LogicalThreadContext.Properties["requestinfo"] = new WebRequestInfo();

            _log.Debug("Application_BeginRequest");
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