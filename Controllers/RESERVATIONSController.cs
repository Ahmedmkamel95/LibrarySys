﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarySystem.Controllers
{
    public class RESERVATIONSController : Controller
    {
        //
        // GET: /RESERVATIONS/
        public ActionResult Index(int id)
        {
            return View();
        }

        //
        // GET: /RESERVATIONS/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /RESERVATIONS/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RESERVATIONS/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RESERVATIONS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /RESERVATIONS/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RESERVATIONS/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /RESERVATIONS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
