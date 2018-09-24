using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Views.LMS
{
    [Authorize]
    public class LMSController : Controller
    {
        // GET: LMS
       
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult InstalledPower()
        {
            return View();
        }



    }
}