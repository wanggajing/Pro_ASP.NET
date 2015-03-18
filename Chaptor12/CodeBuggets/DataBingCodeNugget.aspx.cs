using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chaptor12_CodeBuggets_DataBingCodeNugget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string[] GetCities()
    {
        return new string[] {"London","Paris","<input/>" };
    }
}