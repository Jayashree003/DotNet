﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTo_Click(object sender, EventArgs e)
        {
            UInt64 Carbill = 0;
            if (ddlMobileDrop.SelectedValue != "0")
            {
                Carbill += (Convert.ToUInt64(ddlMobileDrop.SelectedValue) * 30000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Carbill += (Convert.ToUInt64(DropDownList1.SelectedValue) * 80000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Carbill += (Convert.ToUInt64(DropDownList2.SelectedValue) * 35000);
            }
            Session["Car"] = Carbill;
            Response.Redirect("Cart.aspx");
        }
    }
}