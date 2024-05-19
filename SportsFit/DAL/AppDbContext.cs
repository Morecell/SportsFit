using Microsoft.EntityFrameworkCore;
using SportsFit.Models;

namespace SportsFit.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{

		}
		public virtual DbSet<Product> Products { get; set; }
	}
}
