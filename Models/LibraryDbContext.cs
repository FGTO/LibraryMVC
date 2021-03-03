using System;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVC.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
