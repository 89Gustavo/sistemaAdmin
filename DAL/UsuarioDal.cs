using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using ENTIDAD;

namespace DAL
{
    public class UsuarioDal
    {
       
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());

        SqlCommand cmd = new SqlCommand();

        //public UsuarioE LogeoUsuario(string usuario, string clave)
        //{
        //    UsuarioE usuarioE = new UsuarioE();
        //    cn.Open();
        //    cmd = new SqlCommand("sp_ValidarUsuario", cn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = clave;
        //    cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = usuario;

        //    var reader = cmd.ExecuteReader();
        //    while (reader.Read())   
        //    {
        //        usuarioE.usuario = reader["usuario"].ToString();
        //        usuarioE.clave = reader["clave"].ToString();
        //    }
        //    return usuarioE;
        //}

        public UsuarioE Login(string usuario, string clave)
        {
            UsuarioE usuarioE = new UsuarioE();
            try
            {
                cn.Open();

                cmd = new SqlCommand("sp_ValidarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter uUsuario = new SqlParameter();
                uUsuario.ParameterName = "@Usuario";
                uUsuario.SqlDbType = SqlDbType.NVarChar;
                uUsuario.Size = 64;
                uUsuario.Value = usuario;

                SqlParameter uClave = new SqlParameter();
                uClave.ParameterName = "@Clave";
                uClave.SqlDbType = SqlDbType.NVarChar;
                uClave.Size = 128;
                uClave.Value = clave;

                cmd.Parameters.Add(uUsuario);
                cmd.Parameters.Add(uClave);

                SqlDataReader dr = cmd.ExecuteReader(); 

                if (dr.Read())
                {

                    usuarioE.codigoUsuario = Convert.ToInt32(dr["codigoUsuario"]);
                    usuarioE.usuario = dr["usuario"].ToString() ;
                    usuarioE.clave = dr["clave"].ToString();
                  //  usuarioE.usuario = dr["nombre"].ToString();
                }


                return usuarioE;

            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}
