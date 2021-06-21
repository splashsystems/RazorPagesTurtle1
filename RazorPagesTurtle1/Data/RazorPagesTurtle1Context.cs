using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle1.Models;

namespace RazorPagesTurtle1.Data
{
    public class RazorPagesTurtle1Context : DbContext
    {
        public RazorPagesTurtle1Context (DbContextOptions<RazorPagesTurtle1Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTurtle1.Models.Turtle> Turtle { get; set; }
    }
}
