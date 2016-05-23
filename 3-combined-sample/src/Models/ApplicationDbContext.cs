using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using CombinedSample.Models;

namespace CombinedSample.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

		public DbSet<Trip> Trip { get; set; }
	}

	public class Trip
	{
		public int Id { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public string Comment { get; set; }
	}
}
