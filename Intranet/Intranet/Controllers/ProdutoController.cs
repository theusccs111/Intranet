using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intranet.Models;

namespace Intranet.Controllers
{
    public class ProdutoController : Controller
    {
        ProdutoDAL dal = new ProdutoDAL();
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Produto u)
        {
            if (ModelState.IsValid) //verifica se é válido
            {
                dal.Insert(u);
            }
            return View(u);
        }

        public ActionResult ListProduto()
        {
            var list = dal.All();
            return PartialView("_List", list);
        }

    }
}