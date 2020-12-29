using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2020_TP_PortailNER_Agile.Controllers
{
    public class FormController : Controller
    {
        // GET: FormConfirmation
        public ActionResult Confirmation()
        {
            return View();
        }

        public ActionResult Step1()
        {
            return View();
        }
    }
}