using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Incremento
{
    public partial class EstadoVariables : System.Web.UI.Page
    {
        private int total;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtNumero.Text = "0";

            }
          
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
           if(ViewState["Conteo"]!=null)
            {
                total = (int)ViewState["Conteo"] + 1;
            }
            txtNumero.Text = total.ToString();
            ViewState["Conteo"] = total;
        }
    }
}