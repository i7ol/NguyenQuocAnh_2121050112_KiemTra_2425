using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcTest.Data;
using MvcTest.Models;

namespace MvcTest.Controllers
{
    public class TinhDiemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TinhDiemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NguyenQuocAnh
        public async Task<IActionResult> Index()
        {
            return View(await _context.TinhDiem.ToListAsync());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string a,string b,string c)
        {
            c = a + b;
            string tong = "Tong hai so la:" +c;
            @ViewBag.Message = tong;
            return View();
        }
      
    }
}
