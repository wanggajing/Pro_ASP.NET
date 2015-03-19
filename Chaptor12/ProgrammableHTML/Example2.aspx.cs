using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chaptor12_ProgrammableHTML_Example2 : CommonPageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] cities = { "London", "New York", "Paris", " < input/>" };
        string myCity = cities[new Random().Next(cities.Length)];
        mySpan.InnerText = Server.HtmlEncode(myCity);
    }
}