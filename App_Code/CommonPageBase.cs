using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for CommonPageBase
/// </summary>
public class CommonPageBase: Page
{
    protected string GetDayOfWeek()
    {
        return System.DateTime.Now.DayOfWeek.ToString();
    }
}