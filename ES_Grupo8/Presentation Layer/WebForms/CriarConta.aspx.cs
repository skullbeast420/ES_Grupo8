using System;
using BO;
using BR;

namespace Presentation_Layer.WebForms
{
    public partial class Registo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botão para criar conta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BCriarConta_Click(object sender, EventArgs e)
        {

            Utilizador utilizador;

            if(string.IsNullOrEmpty(TBNome.Text)|| string.IsNullOrEmpty(TBEmail.Text) || string.IsNullOrEmpty(TBNif.Text))



            if (DDLSexo.SelectedValue == "")
            {
                Label1.Text = "Please Select a Gender";
            }
            else
                Label1.Text = "Your Choice is: " + DDLSexo.SelectedValue;
        }
    }
}