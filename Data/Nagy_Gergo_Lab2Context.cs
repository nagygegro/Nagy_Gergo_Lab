using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nagy_Gergo_Lab2.Models;

namespace Nagy_Gergo_Lab2.Data
{
    public class Nagy_Gergo_Lab2Context : DbContext
    {
        public Nagy_Gergo_Lab2Context (DbContextOptions<Nagy_Gergo_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nagy_Gergo_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Nagy_Gergo_Lab2.Models.Publisher>? Publisher { get; set; } = default!;

        public DbSet<Nagy_Gergo_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Nagy_Gergo_Lab2.Models.Category>? Category { get; set; }
    }
}
