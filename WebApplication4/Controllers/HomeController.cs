﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Account()
        {

            return View();
        }

        public ActionResult Addteach()
        {
            return View();
        }


        public ActionResult Editteach()
        {
            return View();
        }
    }
}