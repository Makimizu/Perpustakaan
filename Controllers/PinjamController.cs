using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Perpustakaan.Models;

namespace Perpustakaan.Controllers
{
    public class PinjamController : Controller
    {
        private DatabaseContext db;

        public PinjamController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ViewBag.Pinjam = db.Pinjam.ToList();
            Convert.ToDateTime(DateTime.Now).ToString("dd-MM-yyyy");
            return View();
        }

        [HttpGet]
        public IActionResult find(int id)
        {
            var pinjam = db.Pinjam.Find(id);
            return new JsonResult(pinjam);
        }

        [HttpPost]
        public IActionResult Create(string penyewa, string jenisBuku, int lamaPinjam)
        {
            var pinjam = new Pinjam
            {
                Tanggal = DateTime.Now,
                Penyewa = penyewa,
                JenisBuku = jenisBuku,
                LamaPinjam = lamaPinjam,
                TanggalKembali = DateTime.Today.AddDays(double.Parse(lamaPinjam.ToString())),
                Status = "Loan"
            };
            db.Pinjam.Add(pinjam);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(string NoPinjam, string status)
        {
            var pinjam = db.Pinjam.Find(int.Parse(NoPinjam));
            pinjam.Status = status;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
