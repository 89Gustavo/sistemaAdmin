using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class UsuarioE
    {
        public int codigoUsuario { get; set; }

        public string usuario { get; set; }
        public string clave { get; set; }
        public int estatus { get; set; }
        public string usuarioCrea { get; set; }
         public DateTime fechaCrea { get; set; }
         public string usuarioModifica { get; set; }
         public DateTime fechaModifica { get; set; }

        public List<UsuarioE> Usuarios { get; set; }

        public PersonaE personae = new PersonaE();
        public RolE rolE = new RolE();
    }
}
