using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DagiUniversity.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult ShowGrid()
        {
            return View();
        }
    }
}