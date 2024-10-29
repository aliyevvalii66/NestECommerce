using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NestECommerce.Application.Repositories.ProductRep;
using NestECommerce.Persistence.Contexts;
using NestECommerce.Persistence.Repositories.ProductRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence
{
	public static class ServiceRegistration
	{
		public static void PersistenceServices(this IServiceCollection services)
		{

			services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(Configuration.ConnectionString));


			services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
			services.AddScoped<IProductReadRepository, ProductReadRepository>();
		}
	}
}
