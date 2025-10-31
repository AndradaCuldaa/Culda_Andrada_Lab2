using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Culda_Andrada_Lab2.Data;
using Culda_Andrada_Lab2.Models;
using Culda_Andrada_Lab2.Models.ViewModels;

namespace Culda_Andrada_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context _context;

        public IndexModel(Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context context)
        {
            _context = context;
        }

        public CategoryData CategoryD { get; set; } = new CategoryData();

        public async Task OnGetAsync(int? id)
        {
            CategoryD.Categories = await _context.Category
                  .Include(c => c.BookCategories)
                      .ThenInclude(bc => bc.Book)
                          .ThenInclude(b => b.Author)
                  .OrderBy(c => c.CategoryName)
                  .AsNoTracking()
                  .ToListAsync();

            if (id != null)
            {
                CategoryD.CategoryID = id.Value;
                var category = CategoryD.Categories
                    .Where(c => c.ID == id.Value)
                    .SingleOrDefault();

                if (category != null)
                {
                    CategoryD.Books = category.BookCategories
                        .Select(bc => bc.Book);
                }
            }
        }
    }
}
