using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class UsuarioAcesso
    {
        public int IdUsuario { get; set; }

        public int IdGrupoAcesso { get; set; }

        public Usuario usuario { get; set; }
        public GrupoAcesso grupo { get; set; }
    }
}