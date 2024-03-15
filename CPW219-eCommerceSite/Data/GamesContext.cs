using CPW219_eCommerceSite.Models;
using Microsoft.EntityFrameworkCore;

namespace CPW219_eCommerceSite.Data
{
	public class GamesContext : DbContext
	{
		public GamesContext(DbContextOptions<GamesContext> options) : base(options)
		{

		}

		public DbSet<Games> Game { get; set; }
	}
}
