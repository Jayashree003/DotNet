using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTo_Click(object sender, EventArgs e)
        {
            UInt64 Refrigeratorbill = 0;
            if (ddlMobileDrop.SelectedValue != "0")
            {
                Refrigeratorbill += (Convert.ToUInt64(ddlMobileDrop.SelectedValue) * 70000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Refrigeratorbill += (Convert.ToUInt64(DropDownList1.SelectedValue) * 60000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Refrigeratorbill += (Convert.ToUInt64(DropDownList2.SelectedValue) * 15000);
            }
            Session["Refrigerator"] = Refrigeratorbill;
            Response.Redirect("Cart.aspx");
        }
    }
}