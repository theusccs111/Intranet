using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public interface IProduto
    {
        IEnumerable<Produto> All();
        Produto Find(int? id);
        void Insert(Produto produto);
        void Update(Produto produto);
        void Delete(Produto produto);
    }
}