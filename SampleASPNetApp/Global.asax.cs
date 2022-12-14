using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.UI;

namespace SampleASPNetApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-3.6.1.min.js",
                DebugPath = "~/Scripts/jquery-3.6.1.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.1.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.1.js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });

            ScriptManager.ScriptResourceMapping.AddDefinition("jquery.ui.combined", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-ui-3.6.1.min.js",
                DebugPath = "~/Scripts/jquery-ui-3.6.1.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/3.6.1/jquery-ui.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/3.6.1/jquery-ui.js",
                CdnSupportsSecureConnection = true
            });
            ScriptManager.ScriptResourceMapping.AddDefinition("bootstrap", new ScriptResourceDefinition
            {
                Path = "~/Scripts/bootstrap.min.js",
                DebugPath = "~/Scripts/bootstrap.js",
                CdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/5.2.2/js/bootstrap.min.js",
                CdnDebugPath = "https://maxcdn.bootstrapcdn.com/bootstrap/5.2.2/js/bootstrap.js",
                CdnSupportsSecureConnection = true
            });
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);




        }
    }
}