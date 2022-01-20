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
        public IActionResult HobiUrunuListe()
        {
            return View(Models.HobiUrunuVeri.HobiUrunuleri);
        }

        // GET: HobiUrunleri/Details/5
        public ActionResult HobiUrunuDetay(int id)
        {
            var r = Models.HobiUrunuVeri.HobiUrunuleri.FirstOrDefault(x => x.SiraNo == id);
            return View(r);
        }

        // GET: HobiUrunleri/Create
        public ActionResult HobiUrunuEkle()
        {
            return View();
        }

        // POST: HobiUrunleri/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HobiUrunuEkle(Models.HobiUrunu hobiUrunuEkle)
        {
            Models.HobiUrunuVeri.HobiUrunuleri.Add(hobiUrunuEkle);
            return RedirectToAction("HobiUrunuListe");
        }

        // GET: HobiUrunleri/Edit/5
        public ActionResult HobiUrunuDuzenle(int id)
        {
            //  Linq
            //select top 1 * from hobiUrunular where SiraNo = hobiUrunuSiraNo
            var r = Models.HobiUrunuVeri.HobiUrunuleri.FirstOrDefault(x => x.SiraNo == id);
            return View(r);
        }

        // POST: HobiUrunleri/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HobiUrunuDuzenle(Models.HobiUrunu hobiUrunu)
        {
            var r = Models.HobiUrunuVeri.HobiUrunuleri.FirstOrDefault(x => x.SiraNo == hobiUrunu.SiraNo);

            if (r == null)
            {
                return RedirectToAction("HobiUrunuListe");
            }

            r.UrunAdi = hobiUrunu.UrunAdi;
            r.UreticiAdi = hobiUrunu.UreticiAdi;
            r.UrunTuru = hobiUrunu.UrunTuru;
            r.UretimYili = hobiUrunu.UretimYili;
            r.Fiyat = hobiUrunu.Fiyat;

            return RedirectToAction("hobiUrunuListele");
        }

        // GET: HobiUrunleri/Delete/5
        public ActionResult HobiUrunuSil(int id)
        {
            var r = Models.HobiUrunuVeri.HobiUrunuleri.FirstOrDefault(x => x.SiraNo == id);

            Models.HobiUrunuVeri.HobiUrunuleri.Remove(r);

            return View(r);
        }
    }
}
