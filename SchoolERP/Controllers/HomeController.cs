﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SchoolERP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ForgetPass()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}