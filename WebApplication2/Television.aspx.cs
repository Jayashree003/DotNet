using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTo_Click(object sender, EventArgs e)
        {
            UInt64 Televisionbill = 0;
            if (ddlMobileDrop.SelectedValue != "0")
            {
                Televisionbill += (Convert.ToUInt64(ddlMobileDrop.SelectedValue) * 9000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Televisionbill += (Convert.ToUInt64(DropDownList1.SelectedValue) * 10000);
            }
            if (DropDownList2.SelectedValue != "0")
            {
                Televisionbill += (Convert.ToUInt64(DropDownList2.SelectedValue) * 15000);
            }
            Session["Television"] = Televisionbill;
            Response.Redirect("Cart.aspx");
        }
    }
}