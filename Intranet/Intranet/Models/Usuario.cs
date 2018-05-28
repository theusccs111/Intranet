using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DisplayName("Login")]
        public string login { get; set; }

        [Required]
        [DisplayName("Senha")]
        public string senha { get; set; }

        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("E-mail")]
        public string email { get; set; }

        [DisplayName("Telefone")]
        public string telefone { get; set; }

    }
}