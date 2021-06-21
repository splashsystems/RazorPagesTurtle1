using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesTurtle1.Data;
using RazorPagesTurtle1.Models;

namespace RazorPagesTurtle1.Pages.Turtles
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesTurtle1.Data.RazorPagesTurtle1Context _context;

        public CreateModel(RazorPagesTurtle1.Data.RazorPagesTurtle1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Turtle Turtle { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Turtle.Add(Turtle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
