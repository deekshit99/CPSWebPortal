﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CPSWebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ViewBlankCPS()
        {
            string id;
            if (Session["UserID"] != null)
            {
                id = Session["UserName"].ToString();
            }
            return View();
        }

        public ActionResult ViewDraftCPS()
        {
            string id;
            if (Session["UserID"] != null)
            {
                id = Session["UserName"].ToString();
            }
            return View();
        }

        public ActionResult ViewfinalCPS()
        {
            string id;
            if (Session["UserID"] != null)
            {
                id = Session["UserName"].ToString();
            }
            return View();
        }

    }
}