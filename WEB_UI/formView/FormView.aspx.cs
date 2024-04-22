using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static WEB_UI.formulario;

namespace WEB_UI.formView
{
    public partial class FormView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string f = string.Empty;
            string u = string.Empty;

            
            if(Request.QueryString["f"] != null) 
            {
                f = Request.QueryString["f"].ToString().Replace("[", string.Empty).Replace("]", string.Empty).Replace(" ", "+");
               

            }
            nombreFormulario.Text = f;

            this.form(f);
           
        }

        public void form(string f) {
            string path =  System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @".\formulario.json");

            WebClient wc = new WebClient();

            var datos = wc.DownloadString(path);


            var rs = JsonConvert.DeserializeObject<Resultado>(datos);
            //JArray jObject = JsonConvert.DeserializeObject<JArray>(JsonConvert.SerializeObject(parametros.pObjParametros));

            foreach (var fm in rs.data.Where(x => x.formulario.codigoFormulaio == f))
            { 
                string codigo  = fm.formulario.codigoFormulaio.ToString();
                string nombre = fm.formulario.nombreFormView.ToString();
                string  html2 = "  <form class='row g-'>";
                html2 += "<h1>"+nombre+"</h1>";
                html2 += "<h1>" + codigo + "</h1>";
                html2 += " <div class='col-md-6'>" +
                             "<label for='inputEmail4' class='form-label'>Email</label>" +
                             "<input type='email' class='form-control' id='inputEmail4'  runat='server'>" +
                         "</div>";

                html2 += "</form>";
                idFormulario.InnerHtml = html2;

            }

            //string html = "  <form class='row g-'>";
            //html += " <div class='col-md-6'>        " +
            //             "<label for='inputEmail4' class='form-label'>Email</label>" +
            //             "<input type='email' class='form-control' id='inputEmail4'  runat='server'>" +
            //         "</div>";
 
            //html += "</form>";
            //idFormulario.InnerHtml = html;

        
            HtmlButton NewButtonControl = new HtmlButton();

            NewButtonControl.ID = "NewButtonControl";
            NewButtonControl.Attributes["class"] = "btn btn-primary";
            NewButtonControl.InnerHtml = "guardar";

            NewButtonControl.ServerClick += new System.EventHandler(this.Button_Click);

            idFormulario.Controls.Add(NewButtonControl);

        }
        void Button_Click(Object sender, EventArgs e)
        {

            var script = "alert('test');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);


        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            var script = "alert('test');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }


        
    }
}