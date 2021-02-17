using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserAuthentication
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Encrypt.Encrypt enc = new Encrypt.Encrypt();
            SqlConnection myConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BackofficeConnectionString"].ConnectionString);
            SqlCommand myCommand = new SqlCommand();

            myCommand.Parameters.AddWithValue("@email", tb_username.Text);
            myCommand.Parameters.AddWithValue("@pw", enc.EncryptWithPassphrase(tb_password.Text, "Andre"));

            SqlParameter val_output = new SqlParameter();
            val_output.ParameterName = "@retorno";
            val_output.Direction = ParameterDirection.Output;
            val_output.SqlDbType = SqlDbType.Int;
            myCommand.Parameters.Add(val_output);

            SqlParameter val_output2 = new SqlParameter();
            val_output2.ParameterName = "@retorno_perfil";
            val_output2.Direction = ParameterDirection.Output;
            val_output2.SqlDbType = SqlDbType.VarChar;
            val_output2.Size = 30;
            myCommand.Parameters.Add(val_output2);

            SqlParameter val_output3 = new SqlParameter();
            val_output3.ParameterName = "@retorno_utilizador";
            val_output3.Direction = ParameterDirection.Output;
            val_output3.SqlDbType = SqlDbType.VarChar;
            val_output3.Size = 30;
            myCommand.Parameters.Add(val_output3);

            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "login";

            myCommand.Connection = myConn;
            myConn.Open();
            myCommand.ExecuteNonQuery();

            int valor_retornado = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);
            string valor_perfil = myCommand.Parameters["@retorno_perfil"].Value.ToString();
            string utilizador = myCommand.Parameters["@retorno_utilizador"].Value.ToString();
            Session["perfil_nome"] = valor_perfil;
            Session["perfil_ativo"] = valor_retornado;
            Session["utilizador"] = utilizador;


            myConn.Close();

            if (valor_retornado == 0)
            {
                Session["login"] = "sim";
                Response.Redirect("app.aspx");
            }
            else if (valor_retornado == 1)
            {
                Session["login"] = "sim";

                Response.Redirect("app.aspx");
            }
            else if (valor_retornado == 2)
            {
                Session["login"] = "sim";
                Response.Redirect("app.aspx");
            }
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}
