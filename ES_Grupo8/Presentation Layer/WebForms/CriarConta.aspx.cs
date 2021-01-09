using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            if (DDLSexo.SelectedValue == "")
            {
                Label1.Text = "Please Select a Gender";
            }
            else
                Label1.Text = "Your Choice is: " + DDLSexo.SelectedValue;
        }
    }
}