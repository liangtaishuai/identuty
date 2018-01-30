using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace Idlted
{
    public partial class Commation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["index"] = 1;
                BindRepeater();
            }
        }
        protected void BindRepeater()
        {
            PagedDataSource pd = new PagedDataSource();
            pd.DataSource = new CommodityBLL().selCommodity(0);

            pd.AllowPaging = true;
            pd.PageSize = 8;

            int index = (int)ViewState["index"];
            //int index = int.Parse(hdfPageIndex.Value) -1;

            if (index < 1)
                index = 0;

            if (index > pd.PageCount - 1)
                index = pd.PageCount - 1;

            pd.CurrentPageIndex = index;
            //hdfPageIndex.Value = (index+1) + "";
            ViewState["index"] = index;
            lblPageIndex.Text = (index+1).ToString();
            dgdShowData.DataSource = pd;
            dgdShowData.DataBind();
        }

        protected void btnProv_Click(object sender, EventArgs e)
        {
            ViewState["index"] = (int)ViewState["index"] - 1;
            BindRepeater();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            ViewState["index"] = (int)ViewState["index"] + 1;
            BindRepeater();
        }
    }
}