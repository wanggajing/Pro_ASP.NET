using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ParamsModule
/// </summary>
public class ParamsModule: IHttpModule
{
    public void OnLogRequest(Object source, EventArgs e)
    {
        HttpApplication app = source as HttpApplication;
        if (app.Request.Url.LocalPath == "/Chaptor14/Params.aspx" && !app.User.Identity.IsAuthenticated)
        {
            app.Context.AddError(new UnauthorizedAccessException());
        }
    }
    public void Dispose()
    {
    }
    public void Init(HttpApplication context)
    {
        context.PostAuthenticateRequest += new EventHandler(OnLogRequest);
    }
}