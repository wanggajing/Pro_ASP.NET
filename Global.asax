<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        EventCollection.Add(EventSource.Application, "Start");
        Application["message"] = "Application Events";
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
    protected void Application_BeginRequest(object sender, EventArgs e)
    {
        EventCollection.Add(EventSource.Application, "BeginRequest");
        Response.Write(string.Format("Request started at {0}",
        DateTime.Now.ToLongTimeString()));
    }
    protected void Application_EndRequest(object sender, EventArgs e)
    {
        EventCollection.Add(EventSource.Application, "EndRequest");
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
