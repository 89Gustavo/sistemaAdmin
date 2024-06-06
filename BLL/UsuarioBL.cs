using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ENTIDAD;
using DAL;

namespace BLL
{
    public class UsuarioBL
    {
        UsuarioDal usuarioDal = new UsuarioDal();
        //public UsuarioE LogeoUsuario(string usuario, string clave)
        //{
        //    UsuarioDal usuarioDal = new UsuarioDal();
        //    return usuarioDal.LogeoUsuario(usuario, clave);
        //}
        public UsuarioE Login(string usuario, string clave)
        {


            return usuarioDal.Login(usuario, clave);
        }


    }
}
