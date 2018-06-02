using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Intranet.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Descrição do Produto")]
        public string DescProduto { get; set; }

        [DisplayName("Peso")]
        public float Peso { get; set; }

        [Required]
        [DisplayName("Valor")]
        public float Valor { get; set; }

        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        [DisplayName("Data de Compra")]
        public DateTime DataCompra { get; set; }

        [DisplayName("Data de Vencimento")]
        public DateTime DataVencimento { get; set; }

        [DisplayName("Ativo")]
        public bool isAtivo { get; set; }

    }
}
