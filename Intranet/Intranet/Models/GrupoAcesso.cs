using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class GrupoAcesso
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string descricao { get; set; }

        [DisplayName("Ativo?")]
        public bool isAtivo { get; set; }


        public ICollection<UsuarioAcesso> UsuarioAcessos { get; set; }

        public GrupoAcesso()
        {
            UsuarioAcessos = new Collection<UsuarioAcesso>();
        }
    }
}