using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle1.Data;
using RazorPagesTurtle1.Models;

namespace RazorPagesTurtle1.Pages.Turtles
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTurtle1.Data.RazorPagesTurtle1Context _context;

        public IndexModel(RazorPagesTurtle1.Data.RazorPagesTurtle1Context context)
        {
            _context = context;
        }

        public IList<Turtle> Turtle { get;set; }

        public async Task OnGetAsync()
        {
            Turtle = await _context.Turtle.ToListAsync();
        }
    }
}
