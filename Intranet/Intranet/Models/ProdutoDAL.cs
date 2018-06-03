using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Intranet.Models
{
    public class ProdutoDAL : IProduto
    {
        public IEnumerable<Produto> All()
        {
            try
            {
                using (var context = new Context())
                {
                    return context.Produto.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Produto Find(int? codigo)
        {
            using (var context = new Context())
            {
                return context.Produto.FirstOrDefault(u => u.Id == codigo);
            }
        }

        public void Insert(Produto produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException("Produto");
            }

            using (var context = new Context())
            {
                produto.isAtivo = true;
                context.Produto.Add(produto);
                context.SaveChanges();
            }
        }

        public void Update(Produto produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException("Produto");
            }

            using (var context = new Context())
            {
                Produto produto2 = context.Produto.Find(produto.Id);
                produto2.DescProduto = produto.DescProduto;
                produto2.Peso = produto.Peso;
                produto2.Valor = produto.Valor;
                produto2.Quantidade = produto.Quantidade;
                produto2.DataCompra = produto.DataCompra;
                produto2.DataVencimento = produto.DataVencimento;
                produto2.isAtivo = produto.isAtivo;

                context.SaveChanges();
            }
        }

        public void Delete(Produto produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException("Produto");
            }

            using (var context = new Context())
            {
                context.Entry(produto).State = EntityState.Deleted;
                //context.GrupoAcesso.Remove(grupo);
                context.SaveChanges();


            }
        }
    }
}