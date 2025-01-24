using Microsoft.EntityFrameworkCore;
using Testamente.Models;

namespace Testamente.Data
{
	public class MyDbContext :DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{

		}

		public DbSet<Person> People { get; set; }

		public DbSet<Inheritor> Inheritors { get; set; }

		public DbSet<Langelænder> langelænders { get; set; }
	}
}
