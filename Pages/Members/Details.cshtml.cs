using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Culda_Andrada_Lab2.Data;
using Culda_Andrada_Lab2.Models;

namespace Culda_Andrada_Lab2.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context _context;

        public DetailsModel(Culda_Andrada_Lab2.Data.Culda_Andrada_Lab2Context context)
        {
            _context = context;
        }

        public Member Member { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);
            if (member == null)
            {
                return NotFound();
            }
            else
            {
                Member = member;
            }
            return Page();
        }
    }
}
