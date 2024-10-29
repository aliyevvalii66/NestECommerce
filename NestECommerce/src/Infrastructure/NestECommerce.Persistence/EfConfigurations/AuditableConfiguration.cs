using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NestECommerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence.EfConfigurations
{
	public class AuditableConfiguration : IEntityTypeConfiguration<Auditable>
	{
		public void Configure(EntityTypeBuilder<Auditable> builder)
		{
			builder.Property(a => a.CreatedDate)
				  .IsRequired()
				  .HasDefaultValueSql("GETDATE()");

			builder.Property(a => a.EditedDate)
				.IsRequired(false)
				.HasDefaultValueSql("GETDATE()");

			builder.Property(a => a.CreatedBy)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(a => a.EditedBy)
				.IsRequired(false)
				.HasMaxLength(50);
		}
	}
}
