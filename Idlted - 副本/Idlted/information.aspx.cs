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
    public partial class information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            customer cu = ((customer)Session["customer"]);
            if (!IsPostBack)
            {
                Account.Text = cu.Account;
                tetName.Text = cu.Name;
                txtPhone.Text = cu.Phone;
                txtEmail.Text = cu.Email;
                txtAdress.Text = cu.Adress;
            }
        }

        protected void btusave_Click(object sender, EventArgs e)
        {
            customer cu = new customer();
            cu.ID= ((customer)Session["customer"]).ID;
            cu.Name = tetName.Text;
            cu.Phone = txtPhone.Text;
            cu.Email = txtEmail.Text;
            cu.Adress = txtAdress.Text;
            if(new customerBLL().updatecustomer(cu)>0)
            {
                Session["customer"] = new customerBLL().query(cu);
                Label divMaster = (Label)this.Master.FindControl("Lablogin");
                divMaster.Text = ((customer)Session["customer"]).Name;
                Response.Write("<script>alert('修改成功!');</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败!');</script>");
            }
        }
    }
}