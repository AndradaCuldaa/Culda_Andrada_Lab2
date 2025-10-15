using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Culda_Andrada_Lab2.Models;

namespace Culda_Andrada_Lab2.Data
{
    public class Culda_Andrada_Lab2Context : DbContext
    {
        public Culda_Andrada_Lab2Context(DbContextOptions<Culda_Andrada_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Culda_Andrada_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
        public DbSet<Author> Author { get; set; } = default!;
    }
}
