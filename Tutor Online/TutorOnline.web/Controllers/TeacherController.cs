﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Teacher()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult UpdateProfile()
        {
            return View();
        }
        
        public ActionResult ReceivedRequest()
        {
            return View();
        }
        
        public ActionResult ViewFeedback()
        {
            return View();
        }
        
        public ActionResult SendFeedback()
        {
            return View();
        }
    }
}