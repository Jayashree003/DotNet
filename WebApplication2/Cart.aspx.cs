using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncontinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            UInt64 Mobilebill = 0, Laptopbill = 0,Carbill=0 ,Televisionbill=0,Refrigeratorbill=0;
            UInt64 bill = 0;
            Mobilebill = (UInt64)Session["Mobile"];
            Laptopbill = (UInt64)Session["Laptop"];
            Carbill = (UInt64)Session["Car"];
            Televisionbill = (UInt32)Session["Television"];
            Refrigeratorbill = (UInt64)Session["Refrigerator"];
            bill = Mobilebill+ Laptopbill+Carbill+Televisionbill+Refrigeratorbill;
            lblError.Text = "Your bill amount is: " + bill.ToString();

        }
    }
}