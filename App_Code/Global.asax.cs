using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Global
/// </summary>
public class Global : System.Web.HttpApplication
{
    public Global()
    {
        BeginRequest += HandleEvent;
    }
    protected void HandleEvent(object sender, EventArgs e)
    {
        switch (Context.CurrentNotification)
        {
            case RequestNotification.BeginRequest:
                EventCollection.Add(EventSource.Application, "BeginRequest");
                if (Request.RawUrl == "/Time") 
                {
                    Response.Write(Context.Timestamp.ToLongTimeString());
                    CompleteRequest();
                }
                break;
            default:
                string eventName = Context.CurrentNotification.ToString();
                EventCollection.Add(EventSource.Application, eventName);
                break;
        }
    }
    protected void Application_Start(object sender, EventArgs e)
    {
        EventCollection.Add(EventSource.Application, "Start");
        Application["message"] = "Application Events";
        CreateTimeStamp();
    }
    protected void Application_End(object sender, EventArgs e)
    {
        EventCollection.Add(EventSource.Application, "End");
    }
    protected void CreateTimeStamp()
    {
//        This works for the instances of the Global object that are instantiated to handle the request lifecycle, but not for
//those instances created for the application lifecycle and we cause an HttpException when we call CreateTimeStamp
//from the Application_Start method.
        //Session property will return null until the PostAcquireRequestState application event has been triggered. 
        //Session property in HttpApplication Returns the HttpContext.Session value, but throws an HttpException if the value is null.
        string stamp = Context.Timestamp.ToLongTimeString();
        if (Context.Session != null)
        {
            Session["request_timestamp"] = stamp;
        }
        else
        {
            Application["app_timestamp"] = stamp;
        }
    }
    //protected void Application_BeginRequest(object sender, EventArgs e)
    //{
    //    EventCollection.Add(EventSource.Application, "BeginRequest");
    //    Response.Write(string.Format("Request started at {0}",
    //    DateTime.Now.ToLongTimeString()));
    //}
    //protected void Application_EndRequest(object sender, EventArgs e)
    //{
    //    EventCollection.Add(EventSource.Application, "EndRequest");
    //}

    //void Application_Error(object sender, EventArgs e)
    //{
    //    // Code that runs when an unhandled error occurs

    //}

    //void Session_Start(object sender, EventArgs e)
    //{
    //    // Code that runs when a new session is started

    //}

    //void Session_End(object sender, EventArgs e)
    //{
    //    // Code that runs when a session ends. 
    //    // Note: The Session_End event is raised only when the sessionstate mode
    //    // is set to InProc in the Web.config file. If session mode is set to StateServer 
    //    // or SQLServer, the event is not raised.

    //}
}