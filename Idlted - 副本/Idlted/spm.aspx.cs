using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Idlted
{
    public partial class spm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }
        }

        private void BindRepeater()
        {
            Respm.Visible = true;
            Respm.DataSource = new BLL.CommodityBLL().selCommodity(int.Parse(Request.QueryString["ID"]));
            Respm.DataBind();
        }
    }
}