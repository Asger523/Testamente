using Microsoft.EntityFrameworkCore;
using Testamente.Models;

namespace Testamente.EFDB
{
    public class MyDBContext : DbContext
    {
        public DbSet<EFModel> EFModels{ get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }
    }
}
