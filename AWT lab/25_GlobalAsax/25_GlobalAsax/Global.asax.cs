using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace _25_GlobalAsax
{
    public class Global : HttpApplication
    {
        // Called when the application starts
        void Application_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("🔥 Application Started");
        }

        // Called when a new session starts
        void Session_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("🟢 Session Started");
        }

        // Called for unhandled exceptions
        void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            System.Diagnostics.Debug.WriteLine("❌ Application Error: " + ex.Message);
            Server.ClearError();
        }

        // Called when a session ends
        void Session_End(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("🔴 Session Ended");
        }

        // Called when the application ends
        void Application_End(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("🛑 Application Ended");
        }
    }
}