using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.Booklist
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Book Book { get; set; }                       
        
        public CreateModel(ApplicationDbContext db)
        {            
            _db = db;            
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            

            if (ModelState.IsValid)
            {
                await _db.Book.AddAsync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");            
            }
            else
            {
                return Page();
            }
        }       
    }
}
