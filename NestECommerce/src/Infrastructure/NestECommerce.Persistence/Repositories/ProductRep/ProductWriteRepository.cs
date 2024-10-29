using NestECommerce.Application.Repositories.ProductRep;
using NestECommerce.Domain.Entities;
using NestECommerce.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence.Repositories.ProductRep
{
	public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
	{
		public ProductWriteRepository(AppDbContext context) : base(context)
		{
		}
	}
}
