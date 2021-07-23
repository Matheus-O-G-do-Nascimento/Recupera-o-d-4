using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Recuperação_d_4.Models;

namespace Recuperação_d_4.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        musico m1 = new musico();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
           
            List<string> csv = m1.ReadAllLinesCSV("DataBase/usuario.csv");

            
            var logado =
            csv.Find(
                x =>
                x.Split(";")[2] == form["Email"] &&
                x.Split(";")[3] == form["Senha"]
            );


            if (logado != null)
            {
                
                HttpContext.Session.SetString("_UserName", logado.Split(";")[1]);

                return LocalRedirect("~/Home");
            }
            return LocalRedirect("~/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");
        }

    }
}
