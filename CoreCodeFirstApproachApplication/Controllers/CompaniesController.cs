﻿using CoreCodeFirstApproachApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeFirstApproachApplication.Controllers
{
    public class CompaniesController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();
        // GET: CompaniesController
        public ActionResult Index()
        {
            var company = context.Companies.ToList();
            return View(company);
            //return View();
        }

        // GET: CompaniesController/Details/5
        public ActionResult Details(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // GET: CompaniesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompaniesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            try
            {
                context.Companies.Add(company);
                context.SaveChanges();
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CompaniesController/Edit/5
        public ActionResult Edit(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // POST: CompaniesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Company company)
        {
            try
            {
                context.Companies.Update(company);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CompaniesController/Delete/5
        public ActionResult Delete(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // POST: CompaniesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var companyobj = context.Companies.Find(id);
                context.Companies.Remove(companyobj);
                context.SaveChanges();
                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
