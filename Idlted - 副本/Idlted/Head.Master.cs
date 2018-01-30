using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Idlted
{
    public partial class Head : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
            if (Session["customer"] != null)
            {
                Lablogin.Text = ((Model.customer)Session["customer"]).Name;
                Hyperlogin.NavigateUrl = "~/information.aspx";
                Hypeprofile.NavigateUrl= "~/information.aspx";
            }
            else
            {
                Lablogin.Text = "登录";
                Hyperlogin.NavigateUrl = "~/login.aspx";
                Hypeprofile.NavigateUrl = "~/login.aspx";
            }

        }
        protected void BindGrid()
        {
            CommodityTypeRepeater.Visible = true;
            CommodityTypeRepeater.DataSource = new BLL.CommodityTypeBLL().GetCommodityType();
            CommodityTypeRepeater.DataBind();
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session["customer"] = null;
            Response.Write("<script>opener.location.reload();</script>");
        }
    }
}