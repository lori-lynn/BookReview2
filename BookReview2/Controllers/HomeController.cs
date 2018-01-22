﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookReview2.Models;

namespace BookReview2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BookReviewDbEntities db = new BookReviewDbEntities();
            //var bks = (from b in db.Books
                     // select b).ToList();
                     

            return View(db.Books.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}