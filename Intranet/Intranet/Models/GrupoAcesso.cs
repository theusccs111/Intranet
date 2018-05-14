using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class GrupoAcesso
    {
        [Key]
        public int id { get; set; }


        public string descricao { get; set; }
        public bool isAtivo { get; set; }
    }
}