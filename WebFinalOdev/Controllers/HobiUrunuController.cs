using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinalOdev.Controllers
{
    public class HobiUrunuController : Controller
    {
        // GET: HobiUrunleri
        public ActionResult Index()
        {
            return View();
        }

        // GET: HobiUrunleri/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HobiUrunleri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HobiUrunleri/Create
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

        // GET: HobiUrunleri/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HobiUrunleri/Edit/5
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

        // GET: HobiUrunleri/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HobiUrunleri/Delete/5
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
