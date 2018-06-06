using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class Chamado
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int IdAtendente { get; set; }

        public int IdSolicitante { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime DataFinalizado { get; set; }

        public int IdStatus { get; set; }

        public int IdArvore { get; set; }

    }
}