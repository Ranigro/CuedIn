﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CounselorScholarshipDashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        ((Label)Master.FindControl("lblMaster2")).Text = "Scholarship Dashboard";
        
    }
}