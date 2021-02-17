using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserAuthentication
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool validaPW(string password)
        {
            Regex maiusculas = new Regex("[A-Z]");
            Regex minusculas = new Regex("[a-z]");
            Regex numeros = new Regex("[0-9]");
            Regex especial = new Regex("[^a-zA-Z0-9]");
            Regex plica = new Regex("'");

            if (password.Length < 7) return false;
            if (maiusculas.Matches(password).Count < 1) return false;
            if (minusculas.Matches(password).Count < 1) return false;
            if (numeros.Matches(password).Count < 1) return false;
            if (especial.Matches(password).Count < 1) return false;
            if (plica.Matches(password).Count > 0) return false;

            return true;
        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if (validaPW(tb_password.Text) == true)
            {

                Encrypt.Encrypt enc = new Encrypt.Encrypt();
                SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["BackofficeConnectionString"].ConnectionString);
                SqlCommand myCommand = new SqlCommand();

                myCommand.Parameters.AddWithValue("@email", tb_username.Text);
                myCommand.Parameters.AddWithValue("@pass", enc.EncryptWithPassphrase(tb_password.Text,"Andre"));
                myCommand.Parameters.AddWithValue("@nome", tb_name.Text);
                myCommand.Parameters.AddWithValue("@ativo", 1);
                myCommand.Parameters.AddWithValue("@cod_perfil", 4);


                SqlParameter val_output = new SqlParameter();
                val_output.ParameterName = "@retorno";
                val_output.Direction = ParameterDirection.Output;
                val_output.SqlDbType = SqlDbType.Int;

                myCommand.Parameters.Add(val_output);

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "inserir_utilizador";

                myCommand.Connection = myConn;
                myConn.Open();
                myCommand.ExecuteNonQuery();
                int valor_retornado = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);

                myConn.Close();

                if (valor_retornado == 0)
                {
                    lbl_mensagem.Text = "The user already exists";

                }
                else
                {
                    lbl_mensagem.Visible = true;
                    lbl_mensagem.Text = "User registered";
                    Response.Redirect("login.aspx");
                }
            }
            else
            {
                lbl_mensagem.Text = "Your password is weak";
            }
        }

        protected void btn_return_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}