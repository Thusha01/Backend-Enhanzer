using Backend_Enhanzer.DTOs;
using Backend_Enhanzer.Models;
using Microsoft.EntityFrameworkCore;
public class BookUpdateDTO : BookCreateDTO { }

namespace Backend_Enhanzer.Data
{
    public class BookDbContext :DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
