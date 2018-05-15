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


        public ActionResult List()
        {
            return View(dal.All());
        }

        // GET: teste/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: teste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GrupoAcesso grupo = dal.Find(id);
            dal.Delete(grupo);
            return RedirectToAction("Index");
        }

    }
}