using System;
using Ecom.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecom.Infrastructure.Data.Config
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public ProductConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(30);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");

            builder.HasData(
                new Product {Id = 1 , Name ="Product 1",Description ="P1",Price=2000,CategoryId=1 },
                new Product { Id = 2, Name = "Product 2", Description = "P2", Price = 2000, CategoryId = 2 },
                new Product { Id = 3, Name = "Product 3", Description = "P3", Price = 2000, CategoryId = 3 }
                );
        }
    }
}

