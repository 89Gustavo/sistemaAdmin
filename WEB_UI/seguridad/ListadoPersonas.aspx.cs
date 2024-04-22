using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_UI.seguridad
{
    public partial class ListadoPersons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store");
            if (!this.IsPostBack)
            {
               
            }
          
            if (Session["usuario"] == null)
            {
                Response.Redirect("../Login.aspx");
            }


        }
    }
}