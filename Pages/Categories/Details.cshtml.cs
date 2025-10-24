using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Culda_Andrada_Lab2.Data;
using Culda_Andrada_Lab2.Models;

namespace Culda_Andrada_Lab2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context _context;

        public DetailsModel(Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context context)
        {
            _context = context;
        }

        public BookCategory BookCategory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookcategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.ID == id);
            if (bookcategory == null)
            {
                return NotFound();
            }
            else
            {
                BookCategory = bookcategory;
            }
            return Page();
        }
    }
}
