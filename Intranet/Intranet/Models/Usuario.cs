using System;
using System.Collections.Generic;
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
        public string login { get; set; }

        [Required]
        public string senha { get; set; }

    }
}