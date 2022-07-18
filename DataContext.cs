using Microsoft.EntityFrameworkCore;
using Book1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book1.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Books> Book { get; set; }
        public DbSet<Book> BookType { get; set; }

    }
}
