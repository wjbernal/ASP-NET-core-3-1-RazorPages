using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.Booklist
{
    public class BookUsingApiModel : PageModel
    {
        public string Title;

        public BookUsingApiModel()
        {
            Title = "My Book List using API, JavaScript & Ajax";
        }
        
    }
}
