using Intranet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class GrupoAcessoController : Controller
    {
        GrupoAcessoDAL dal = new GrupoAcessoDAL();
        //UsuarioAcessoDAL dal2 = new UsuarioAcessoDAL();

        Context conn = new Context();

        // GET: GrupoAcesso
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(GrupoAcesso u)
        {
            if (ModelState.IsValid) //verifica se é válido
            {
                dal.Insert(u);
            }
            return View(u);
        }


        public ActionResult ListGrupos()
        {
            var list = dal.All();
            return PartialView("_List",list);
        }

        public ActionResult ListGruposFiltroUsuario(int? usuario)
        {
            var list = dal.AllUsuario(usuario);


            return PartialView("_ListGruposFiltroUsuario", list);
        }

        [HttpPost]
        public JsonResult Check(int id)
        {
            GrupoAcesso g = dal.Find(id);
            if (g.isAtivo)
            {
                g.isAtivo = false;
            }
            else
            {
                g.isAtivo = true;
            }
            dal.Update(g);
            return Json(new { success = true });
        }

        

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoAcesso grupo = dal.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,descricao,isAtivo")] GrupoAcesso grupo)
        {
            if (ModelState.IsValid)
            {
                dal.Update(grupo);
                return RedirectToAction("Index");
            }
            return View(grupo);
        }


        [HttpPost]
        public JsonResult DeleteGrupo(int id)
        {
            GrupoAcesso g = dal.Find(id);
            dal.Delete(g);
            return Json(new { success = true });
        }


       
        [HttpPost]
        public JsonResult DeleteUsuarioAcesso(int IdGrupoAcesso, int IdUsuario)
        {
            

            // return one instance each entity by primary key
		var usuario = conn.Usuario.FirstOrDefault(p => p.id == IdUsuario);
		var grupo = conn.GrupoAcesso.FirstOrDefault(s => s.id == IdGrupoAcesso);

		// call Remove method from navigation property for any instance
		// supplier.Product.Remove(product);
		// also works
		usuario.grupos.Remove(grupo);

		// call SaveChanges from context
		conn.SaveChanges();

           
            return Json(new { success = true });
        }


        public ActionResult AtribuirGrupos()
        {
            using (Context c = new Context())
            {
                var result = (from g in c.GrupoAcesso select g).ToList();
                if(result != null)
                {
                    ViewBag.ListaGrupos = result.Select(x => new SelectListItem { Text = x.descricao, Value = x.id.ToString() });
                }

                var result2 = (from g in c.Usuario select g).ToList();
                if (result2 != null)
                {
                    ViewBag.ListaUsuarios = result2.Select(x => new SelectListItem { Text = x.login, Value = x.id.ToString() });
                }

            }

            return View();
        }


        [HttpPost]
        public ActionResult AtribuirGrupos(int IdGrupoAcesso,int IdUsuario)
        {

            // 1
            Usuario p = new Usuario { id = IdUsuario };
            // 2
            conn.Usuario.Add(p);
            // 3
            conn.Usuario.Attach(p);

            // 1
            GrupoAcesso s = new GrupoAcesso { id = IdGrupoAcesso };
            // 2
            conn.GrupoAcesso.Add(s);
            // 3
            conn.GrupoAcesso.Attach(s);

            // like previous method add instance to navigation property
            p.grupos.Add(s);

            // call SaveChanges
            conn.SaveChanges();



            return RedirectToAction("AtribuirGrupos", "GrupoAcesso");
        }

    }
}