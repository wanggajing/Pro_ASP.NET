﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chaptor12_CodeBuggets_StandardCodeNugget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected string GetCity()
    {
        string[] cities= { " < input id = password/> < button type = submit > Submit</button > " };
        return cities[new Random().Next(cities.Length)];        
    }
}