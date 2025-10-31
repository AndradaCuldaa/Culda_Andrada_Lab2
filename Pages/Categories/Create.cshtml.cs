using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Culda_Andrada_Lab2.Data;
using Culda_Andrada_Lab2.Models;

namespace Culda_Andrada_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context _context;

        public CreateModel(Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookID"] = new SelectList(_context.Book, "ID", "ID");
        ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "CategoryName");
            return Page();
        }

        [BindProperty]
        public BookCategory BookCategory { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookCategory.Add(BookCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
