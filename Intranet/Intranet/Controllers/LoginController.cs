using Intranet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class LoginController : Controller
    {
        UsuarioDAL dal = new UsuarioDAL();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario u)
        {
            if (ModelState.IsValid) //verifica se é válido
            {
                /*string cifra = dal.Cifrar(u.senha);
                u.senha = dal.Cifrar(u.senha);*/
                if (dal.GetUsuarioPorLoginSenha(u) != null)
                {
                    Session["usuarioLogadoID"] = u.id.ToString();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Registrar", "Login");
                }
            }
            return View(u);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult RecuperaSenha()
        {
            return View();
        }
    }
}