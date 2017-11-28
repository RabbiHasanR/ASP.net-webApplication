using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ApplicationEventsDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            //create application start variable
            Application["totalApplication"] = 0;
            Application["totalUserSession"] = 0;
            //increment totalApplication by 1
            Application["totalApplication"] = (int)Application["totalApplication"] + 1;

        }
        void Session_start(object sender, EventArgs e)
        {
            //increment totalUserSession by 1
            Application["totalUserSession"] = (int)Application["totalUserSession"] + 1;
        }
        void Session_end(object sender, EventArgs e)
        {
            //decrement totalUserSession by 1
            Application["totalUserSession"] = (int)Application["totalUserSession"] - 1;
        }
    }
}