using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Recuperação_d_4.Models;

namespace Recuperação_d_4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        musico m1 = new musico();
    
        [Route("Login")]

        public IActionResult Logar(IFormCollection form)
        {
            List<string> csv = m1.ReadAllLinesCSV("DataBase/usuario.csv");

            var Logado =
            csv.Find(
                x =>
                x.Split(";")[2] == form["Email"] &&
                x.Split(";")[3] == form["Senha"]
            );

            if (Logado !=null)
            {
                  HttpContext.Session.SetString("_UserName",Logado.Split(";")[1]);
                      return LocalRedirect("~/");
            }

            return LocalRedirect("~/Login");
        }
    }
}