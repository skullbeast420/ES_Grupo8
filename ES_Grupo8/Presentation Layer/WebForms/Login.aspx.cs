using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows;
using BO;
using BR;


namespace Presentation_Layer.WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        Rules aux = new Rules();

        /// <summary>
        /// Botão para iniciar sessão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BIniciarSessao_click(object sender, EventArgs e)
        {
           
            Utilizador ut;
            string email, password;

            //Caso haja algum espaço em branco
            if (string.IsNullOrEmpty(TBEmail.Text) || string.IsNullOrEmpty(TBPassword.Text))
            {
                MessageBox.Show("Não pode deixar espaços em branco!");
            }
            else
            {
                email = TBEmail.Text;
                password = TBPassword.Text;

                ut = aux.Login(Utilizadores.currentUser, email, password);

                //Interpreta o valor retornado da função Login
                if (ut != null)
                {
                    MessageBox.Show("Login efetuado com sucesso");

                    //Para abrir a Home Page
                    string url = string.Format("~/WebForms/HomePage.aspx");
                    Response.Redirect(url);
                }
                else if (ut == null)
                {
                    MessageBox.Show("Não existe uma conta com esses dados!");
                }
            }
        }
    }
}