﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Westwind.Utilities;

namespace Westwind.Globalization.Sample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // override configuration values
            //DbResourceConfiguration.Current.ConnectionString = "SqlServerCeLocalizations";
        }

        protected void Application_BeginRequest()
        {
            WebUtils.SetUserLocale(currencySymbol: "$");
            Trace.WriteLine("App_BeginRequest - Culture: " + Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
        }
  
    }

}
