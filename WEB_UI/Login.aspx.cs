using BLL;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_UI
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store");
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        string Patron = "InfoToolsSV";

        //protected void ingrese_Click(object sender, EventArgs e) 
        //{
        //    try
        //    {
        //        //d
        //        SqlCommand cmd = new SqlCommand("sp_login", con);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar).Value = usuario.Text;
        //        cmd.Parameters.Add("@Clave", System.Data.SqlDbType.VarChar).Value = clave.Text;
        //        cmd.Parameters.Add("@Patron", System.Data.SqlDbType.VarChar).Value = Patron;
        //        con.Open();
        //        SqlDataReader rd = cmd.ExecuteReader();

        //        if (rd.Read())
        //        {
        //            Session["codigoRol"] = rd[3].ToString();
        //            Session["usuario"] = rd[4].ToString();
        //            Response.Redirect("/sistemaAdmin/formview/FormView.aspx");
        //        }
        //        con.Open();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        protected void ingrese_Click(object sender, EventArgs e) 
        {
            UsuarioBL usuariob = new UsuarioBL();
            UsuarioE objUsuario = usuariob.Login(usuario.Text, clave.Text);

            if (objUsuario.codigoUsuario != 0)
            {
                //this.ingresar.Attributes.Add("OnClick", "javascript: succes();");
                Session["usuario"] = objUsuario.usuario;

                string JavaScript = "succes('/sistemaAdmin/formview/FormView.aspx', '!Biemvenido "+ objUsuario.usuario + "!');";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", JavaScript, true);

            }
            else
            {


                string JavaScript = "warging('/sistemaAdmin/Login.aspx', '!Usuario o Clave son Incorrectas!');";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", JavaScript, true);
                //ScriptManager.RegisterClientScriptBlock(this, GetType(), "/login.aspx", "warging();", true);

                //ScriptManager.RegisterStartupScript(this, this.GetType(page), "Popup", "warging().then((value) => { window.location ='/login.aspx'; });", true);
                //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "warging();", true);
                //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successalert('Message 2');", true);
                //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successalert('Message 3');", true);
                //this.ingresar.Attributes.Add("OnClick", "javascript: warging();");
                //  this.ingresar.Attributes.Add("onclick", "<script> warging();</script>");
                // Response.Redirect("/login.aspx");
                //var script = "alert('usuario o contraseña incorrecto');";
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                //Response.Redirect("/login.aspx");
            }
        }

    }
}