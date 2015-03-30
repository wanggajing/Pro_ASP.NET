using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Global
/// </summary>
public class Global : System.Web.HttpApplication
{
    private DateTime startTime;
    protected void Application_Start(object sender, EventArgs e)
    {
        EventCollection.Add(EventSource.Application, "Start");
        Application["message"] = "Application Events";
    }
    protected void Application_End(object sender, EventArgs e)
    {
        EventCollection.Add(EventSource.Application, "End");
    }
}