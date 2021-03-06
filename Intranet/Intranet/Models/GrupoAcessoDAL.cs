﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public IEnumerable<GrupoAcesso> AllUsuario(int? Id)
        {
            try
            {
                using (var context = new Context())
                {
                    

                    Usuario u = context.Usuario.Find(Id);

                    // contem a lista de grupos do usuario Id
                   return u.grupos.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public GrupoAcesso Find(int? codigo)
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
                grupo.isAtivo = true;
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
                GrupoAcesso grupo2 = context.GrupoAcesso.Find(grupo.id);
                grupo2.descricao = grupo.descricao;
                grupo2.isAtivo = grupo.isAtivo;

                context.SaveChanges();

                


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
                context.Entry(grupo).State = EntityState.Deleted;
                //context.GrupoAcesso.Remove(grupo);
                context.SaveChanges();

                
            }

        }


    }
}