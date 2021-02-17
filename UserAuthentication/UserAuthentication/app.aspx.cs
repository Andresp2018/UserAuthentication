using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserAuthentication
{
    public partial class app : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                if (Session["perfil_ativo"].ToString() == "1")
                {
                    pnl_login_0.Visible = false;
                    pnl_login_2.Visible = false;
                    btn_GoRegister.Visible = false;
                    pnl_login_1.Visible = true;
                    btn_return_login.Visible = false;


                }

                else if (Session["perfil_ativo"].ToString() == "0")
                {
                    pnl_login_1.Visible = false;
                    pnl_login_2.Visible = false;
                    pnl_login_0.Visible = true;
                    btn_GoRegister.Visible = true;
                    btn_return_login.Visible = false;

                }
                else if (Session["perfil_ativo"].ToString() == "2")
                {
                    pnl_login_0.Visible = false;
                    pnl_login_1.Visible = false;
                    pnl_login_2.Visible = true;
                    btn_return_login.Visible = true;

                }
            }
        }

        protected void btn_GoRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}