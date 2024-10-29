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
	public class ProductReadRepository : ReadRepsoitory<Product>, IProductReadRepository
	{
		public ProductReadRepository(AppDbContext context) : base(context)
		{
		}
	}
}
