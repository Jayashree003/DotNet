using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTo_Click(object sender, EventArgs e)
        {
            UInt64 Laptopbill = 0;
            if (ddlMobileDrop.SelectedValue != "0")
            {
                Laptopbill += (Convert.ToUInt64(ddlMobileDrop.SelectedValue) * 90000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Laptopbill += (Convert.ToUInt64(DropDownList1.SelectedValue) * 100000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Laptopbill += (Convert.ToUInt64(DropDownList2.SelectedValue) * 150000);
            }
            Session["Laptop"] = Laptopbill;
            Response.Redirect("Cart.aspx");
        }
    }
}