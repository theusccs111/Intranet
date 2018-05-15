using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Models
{
    public interface IGrupoAcesso
    {
        IEnumerable<GrupoAcesso> All();
        GrupoAcesso Find(int? id);
        void Insert(GrupoAcesso grupo);
        void Update(GrupoAcesso grupo);
        void Delete(GrupoAcesso grupo);
    }
}
