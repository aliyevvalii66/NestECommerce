using Microsoft.EntityFrameworkCore;
using NestECommerce.Application.Repositories;
using NestECommerce.Domain.Commons;
using NestECommerce.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence.Repositories
{
	public class WriteRepository<T> : IWriteRepository<T>
		where T : Auditable
	{
		private readonly AppDbContext _context;

		public WriteRepository(AppDbContext context)
        {
            _context = context;
        }
		public DbSet<T> Table => _context.Set<T>();
	}
}
