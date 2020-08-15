﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopManagementSystem.Controllers
{
    public class BuyerController : Controller
    {
        // GET: BuyerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BuyerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BuyerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuyerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BuyerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuyerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BuyerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuyerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
