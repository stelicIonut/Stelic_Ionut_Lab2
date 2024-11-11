using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stelic_Ionut_Lab2.Models;

namespace Stelic_Ionut_Lab2.Data
{
    public class Stelic_Ionut_Lab2Context : DbContext
    {
        public Stelic_Ionut_Lab2Context (DbContextOptions<Stelic_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Stelic_Ionut_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Stelic_Ionut_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Stelic_Ionut_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Stelic_Ionut_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Stelic_Ionut_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Stelic_Ionut_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
