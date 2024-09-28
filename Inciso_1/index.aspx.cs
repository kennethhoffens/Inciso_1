using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inciso_1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_usuarios.Text.Trim() == string.Empty)
            {
               
            }
            else if (txt_pass.Text.Trim() == string.Empty)
            {
                
            }
            else
            {
                //! lOGICA DE NEGOCIO PARA REALIZAR SOLICITUD.
            }
        }
    }
}