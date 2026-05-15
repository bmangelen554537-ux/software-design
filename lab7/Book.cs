using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab7
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        // This property creates the format: [1] The Great Gatsby - F. Scott Fitzgerald
        public string DisplayText => $"[{Id}] {Title} - {Author}";
    }

    // This class handles the connection to your database
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Creates a local database file named 'library.db'
            optionsBuilder.UseSqlite("Data Source=library.db");
        }
    }
}
