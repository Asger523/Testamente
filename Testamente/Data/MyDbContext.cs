using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Testamente.Models;


namespace Testamente.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
            
        }   

        public DbSet<Person> Persons { get; set; }

        public DbSet<UnderPersoner> UnderPersoners { get; set;}
    }
}
