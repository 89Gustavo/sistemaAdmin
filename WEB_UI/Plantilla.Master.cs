using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;


namespace WEB_UI
{
    public partial class Plantilla : System.Web.UI.MasterPage
    {
        DataTable Menus = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store");
            if (!this.IsPostBack)
            {
                this.BindMenu();
            }
            if (Session["usuario"] != null)
            {
                divuser.Visible = true;
                lblusuario.Text = Session["usuario"].ToString();
            }
            else
            {
                divuser.Visible = false;
                lblusuario.Text = string.Empty;
            }
            if (Session["usuario"] == null) {
                Response.Redirect("/sistemaAdmin/Login.aspx");
            }
        }

        protected void cerrarSesion_Click(object sender, EventArgs e)
        {

            Session["usuario"] = null;
            Session["codigoRol"] = null;
           
            Response.Redirect("../Login.aspx");
            HttpContext.Current.Session.Abandon();
        }
        protected void rptMenu_OnItemBound(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    if (Menus != null)
                    {
                        DataRowView drv = e.Item.DataItem as DataRowView;
                        string ID = drv["Menu_Id"].ToString();
                        string Title = drv["Menu_Desc"].ToString();
                        DataRow[] rows = Menus.Select("Parent_Menu_Id=" + ID);
                        if (rows.Length > 0)
                        {

                            StringBuilder sb = new StringBuilder();
                          //  sb.Append("<ul data-target='#" + Title + "' class='reeview-menu'> ");
                            foreach (var item in rows)
                            {
                                string parentId = item["Menu_Id"].ToString();
                                string parentTitle = item["Menu_Desc"].ToString();

                                DataRow[] parentRow = Menus.Select("Parent_Menu_Id=" + parentId);

                                if (parentRow.Count() > 0)
                                {

                                    sb.Append("<ul class='nav nav-treeview'>");
                                    sb.Append(" <li class='nav-item'><a href='" + item["Navigate_Url"] + "' class='nav-link'><i class='"+ item["CssFont"] + "'>");
                                    sb.Append(    "</i>" + item["Description"] + " </a></li>");
                                    sb.Append("</ul>");


                                }
                                else
                                {
                                    sb.Append("<ul class='nav nav-treeview'>");
                                    sb.Append(" <li  class='nav-item'><a href='" + item["Navigate_Url"] + "' class='nav-link'><i class='"+ item["CssFont"] + "'>");
                      
                                    sb.Append("</i>" + item["Description"] + " </a></li>");
                                    sb.Append("</ul>");
                                }
                                sb = CreateChild(sb, parentId, parentTitle, parentRow);
                            }
                         //   sb.Append("</ul>");
                            (e.Item.FindControl("ltrlSubMenu") as Literal).Text = sb.ToString();
                        }
                    }
                }
            }
        }

        private StringBuilder CreateChild(StringBuilder sb, string parentId, string parentTitle, DataRow[] parentRows)
        {
            if (parentRows.Length > 0)
            {
                sb.Append("<li id='" + parentTitle + ">");
                foreach (var item in parentRows)
                {
                    string childId = item["Menu_Id"].ToString();
                    string childTitle = item["Menu_Desc"].ToString();
                    DataRow[] childRow = Menus.Select("Parent_Menu_Id=" + childId);

                    if (childRow.Count() > 0)
                    {

                        sb.Append("<li" + childTitle + ">  <a href='" + item["Navigate_Url"] + "'>" + item["Description"] + "<span class='arrow'>" + item["Description"] + "</a>");
                        
                        sb.Append("</li>");


                    }
                    else
                    {
                        sb.Append("<li><a href='" + item["Navigate_Url"] + "'>" + item["Description"] + " </a>");
                     
                        sb.Append("</li>");
                    }
                    CreateChild(sb, childId, childTitle, childRow);
                }
                sb.Append("</li>");

            }
            return sb;
        }

        private void BindMenu()
        {
            Menus = GetData("Select Menu_ID,Parent_Menu_Id,Menu_Desc,Description,Navigate_Url,CssFont from [Menu]");
            DataView view = new DataView(Menus);
            view.RowFilter = "Parent_Menu_ID = 0";
            this.rptCategories.DataSource = view;
            this.rptCategories.DataBind();
        }

        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
    }
}