﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Lesson9C.Models;

namespace COMP2007_S2016_Lesson9C.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);

            return message;
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            var album = new Album("Album " + id);

            return View(album);
        }
    }
}