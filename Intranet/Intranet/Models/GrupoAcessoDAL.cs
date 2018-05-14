using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class GrupoAcessoDAL : IGrupoAcesso
    {
        public IEnumerable<GrupoAcesso> All()
        {
            try
                {
                    using (var context = new Context())
                    {
                        return context.GrupoAcesso.ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            
        }

        public GrupoAcesso Find(int codigo)
        {
            using (var context = new Context())
            {
                return context.GrupoAcesso.FirstOrDefault(u => u.id == codigo);
            }
        }

        public void Insert(GrupoAcesso grupo)
        {
            if (grupo == null)
            {
                throw new ArgumentNullException("GrupoAcesso");
            }

            using (var context = new Context())
            {
                context.GrupoAcesso.Add(grupo);
                context.SaveChanges();
            }

        }

        public void Update(GrupoAcesso grupo)
        {
            if (grupo == null)
            {
                throw new ArgumentNullException("GrupoAcesso");
            }

            using (var context = new Context())
            {
                var grupo2 = context.GrupoAcesso.Find(grupo.id);
                //context.GrupoAcesso.

                //context.SaveChanges();
            }

        }

        public void Delete(GrupoAcesso grupo)
        {
            if (grupo == null)
            {
                throw new ArgumentNullException("GrupoAcesso");
            }

            using (var context = new Context())
            {
                context.GrupoAcesso.Remove(grupo);
                context.SaveChanges();
            }

        }


    }
}