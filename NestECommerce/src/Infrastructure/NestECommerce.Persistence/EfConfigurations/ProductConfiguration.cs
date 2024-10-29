using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NestECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence.EfConfigurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(250);

			builder.HasOne(x => x.Category)
				.WithMany(x => x.Products)
				.HasForeignKey(x => x.CategoryId);

		}
	}
}
