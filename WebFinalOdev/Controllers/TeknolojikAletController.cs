using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinalOdev.Controllers
{
    public class TeknolojikAletController : Controller
    {
        // GET: Teknoloji
        public ActionResult Index()
        {
            return View();
        }

        // GET: Teknoloji/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teknoloji/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teknoloji/Create
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

        // GET: Teknoloji/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teknoloji/Edit/5
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

        // GET: Teknoloji/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teknoloji/Delete/5
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
