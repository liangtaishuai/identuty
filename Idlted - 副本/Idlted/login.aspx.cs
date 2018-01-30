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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btulogin_Click(object sender, EventArgs e)
        {
            customer cu = new customer();
            cu.Account = ACC.Text;
            cu.Pssword = password.Text;
            customer culist = new customerBLL().selcustomer(cu);
            if (culist.ID<0)
            {
                tip.Text = "账号或密码错误，请重新输入！";
            }
            else
            {
                Session["customer"] = culist;
                Response.Redirect("index.aspx");
            }
        }
    }
}