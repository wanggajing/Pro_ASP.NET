using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chaptor14_Params : System.Web.UI.Page
{
//    The problem here is that the Params property (and the directly applied indexer) looks for data in a specific order:
//the query string, form data, and then cookies. By manually specifying a value for the query string, we are able to
//override the form data value.
//There are two lessons here. The first is that the order in which the request data is searched matters and, if the
//source of the data is important, you should use the separate QueryString, Form, and Cookies properties.
//The second, and most important, lesson is that you should never put important data in the response without the
//expectation that the user will change, replace, or otherwise manipulate it. Data that you don’t want the user to see and
//change should be stored in session and user data—not in cookies, not in the query string, and, most certainly, not in
//hidden form elements.
    //output will be Access Level: nomal
    //however if you use Params.aspx?accessLevel=High, then the output will be Acess Level: High
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Access Level:" + Request["accessLevel"];
    }
}