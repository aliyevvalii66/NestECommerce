using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NestECommerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence.EfConfigurations
{
	public class BaseConfiguration : IEntityTypeConfiguration<BaseEntity>
	{
		public void Configure(EntityTypeBuilder<BaseEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Version)
				.IsRequired();
		}
	}
}
