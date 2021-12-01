using CoreCodeFirstApproachApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeFirstApproachApplication.Controllers
{
    public class CompanyController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();
        public IActionResult Index()
        {
            var companies = context.Companies.ToList();
            return View(companies);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {
            context.Companies.Add(company);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int Id)
        {
            var company = context.Companies.Where(c => c.CompanyId == Id).FirstOrDefault();
            return View(company);
        }

        public IActionResult Delete(int Id)
        {
            var company = context.Companies.Find(Id);
            return View(company);
        }
        [HttpPost]
        public IActionResult Delete(int Id, Company company)
        {
            var companyobj = context.Companies.Find(Id);
            context.Companies.Remove(companyobj);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int Id)
        {
            var company = context.Companies.Find(Id);
            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            context.Companies.Update(company);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
