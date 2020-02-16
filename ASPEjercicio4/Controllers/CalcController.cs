using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPEjercicio4.Models;
namespace ASPEjercicio4.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]
        public ActionResult Index(calc c,string operacion)
        {
            if (operacion == "sumar") c.resultado = c.n1 + c.n2;
            else if (operacion=="restar") c.resultado = c.n1 - c.n2;
            else if (operacion == "multiplicar") c.resultado = c.n1 * c.n2;
            else if (operacion == "dividir") c.resultado = c.n1 / c.n2;


            return View(c);
        }
    }
}