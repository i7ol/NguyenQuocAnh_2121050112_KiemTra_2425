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
    public class NguyenQuocAnhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NguyenQuocAnhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NguyenQuocAnh
        public async Task<IActionResult> Index()
        {
            return View(await _context.NguyenQuocAnh.ToListAsync());
        }

        // GET: NguyenQuocAnh/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenQuocAnh = await _context.NguyenQuocAnh
                .FirstOrDefaultAsync(m => m.MaSv == id);
            if (nguyenQuocAnh == null)
            {
                return NotFound();
            }

            return View(nguyenQuocAnh);
        }

        // GET: NguyenQuocAnh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NguyenQuocAnh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSv,sdt,maso")] NguyenQuocAnh nguyenQuocAnh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguyenQuocAnh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguyenQuocAnh);
        }

        // GET: NguyenQuocAnh/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenQuocAnh = await _context.NguyenQuocAnh.FindAsync(id);
            if (nguyenQuocAnh == null)
            {
                return NotFound();
            }
            return View(nguyenQuocAnh);
        }

        // POST: NguyenQuocAnh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSv,sdt,maso")] NguyenQuocAnh nguyenQuocAnh)
        {
            if (id != nguyenQuocAnh.MaSv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguyenQuocAnh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguyenQuocAnhExists(nguyenQuocAnh.MaSv))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nguyenQuocAnh);
        }

        // GET: NguyenQuocAnh/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenQuocAnh = await _context.NguyenQuocAnh
                .FirstOrDefaultAsync(m => m.MaSv == id);
            if (nguyenQuocAnh == null)
            {
                return NotFound();
            }

            return View(nguyenQuocAnh);
        }

        // POST: NguyenQuocAnh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nguyenQuocAnh = await _context.NguyenQuocAnh.FindAsync(id);
            if (nguyenQuocAnh != null)
            {
                _context.NguyenQuocAnh.Remove(nguyenQuocAnh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguyenQuocAnhExists(string id)
        {
            return _context.NguyenQuocAnh.Any(e => e.MaSv == id);
        }
    }
}
