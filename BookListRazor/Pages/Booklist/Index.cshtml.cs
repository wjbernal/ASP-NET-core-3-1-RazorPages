using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.Booklist
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public string Title { get; set; }
        
        public IndexModel(ApplicationDbContext db)
        {
            Title = "My Book List using baisc HTML & .NET core";
            _db = db;               
        }   

        // create a list of Ienumerale of books
        // This is  the list to be retourned
        public IEnumerable<Book> Books { get; set; }

        
        public async Task OnGet()
        {
            
            Books = await _db.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await _db.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _db.Book.Remove(book);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
