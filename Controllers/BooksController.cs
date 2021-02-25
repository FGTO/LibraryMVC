using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryDbContext _db;

        public BookController(LibraryDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Books.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookFromDb = await _db.Books.FirstOrDefaultAsync(u => u.Id == id);
            if (bookFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }
            _db.Books.Remove(bookFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
    }
}
