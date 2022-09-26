using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWebLab5
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCookies_Click(object sender, EventArgs e)
        {
            Response.Cookies["Mensaje"]["Mensaje1"] = txtCookie.Text;
            Response.Cookies["Mensaje"]["Mensaje2"] = txtCookie.Text + " Segundo";
            Response.Cookies["Mensaje"].Expires = DateTime.Now.AddSeconds(30);
        }

        protected void btnLeerCookies_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["Mensaje"] != null)
            lblCookie.Text = Request.Cookies["Mensaje"].Value.ToString();
        }
    }
}