using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Presentation_Layer.WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BIniciarSessao_click(object sender, EventArgs e)
        {
            //this.Hide();
            HomePage hp = new HomePage();
            //hp.ShowDialogue();
        }
    }
}