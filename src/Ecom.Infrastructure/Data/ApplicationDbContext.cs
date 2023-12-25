using System;
using System.Reflection;
using Ecom.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Product> GetProducts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

		}
	}
}