﻿using Intranet.Models;
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

        public ActionResult ListGrupos()
        {
            var list = dal.All();
            return PartialView("_List",list);
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


        public ActionResult List()
        {
            return View(dal.All());
        }


        [HttpPost]
        public JsonResult DeleteGrupo(int id)
        {
            GrupoAcesso g = dal.Find(id);
            dal.Delete(g);
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
            }

            return View();
        }

    }
}