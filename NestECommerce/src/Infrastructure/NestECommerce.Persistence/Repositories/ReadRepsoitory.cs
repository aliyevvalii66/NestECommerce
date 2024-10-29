using Microsoft.EntityFrameworkCore;
using NestECommerce.Application.Repositories;
using NestECommerce.Application.Utils;
using NestECommerce.Domain.Commons;
using NestECommerce.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence.Repositories
{
	public class ReadRepsoitory<T> : IReadRepository<T>
		where T : Auditable
	{
		private readonly AppDbContext _context;

		public ReadRepsoitory(AppDbContext context)
		{
			_context = context;
		}

		public DbSet<T> Table => _context.Set<T>();

		public IQueryable<T> GetAll()
			=> Table.AsQueryable();

		public async Task<T> GetByIdAsync(Guid id)
			=> await Table.FirstOrDefaultAsync(x => x.Id == id);
		public async Task<PagedResponse<T>> GetPagedAsync(PaginationParameters paginationParameters)
		{
			var query = GetAll();
			var totalCount = await query.CountAsync();
			var data = await query
			.Skip((paginationParameters.PageNumber - 1) * paginationParameters.PageSize)
			.Take(paginationParameters.PageSize)
			.ToListAsync();

			return new PagedResponse<T>
			{
				Data = data,
				PageNumber = paginationParameters.PageNumber,
				PageSize = paginationParameters.PageSize,
				TotalRecords = totalCount
			};
		}
	}
}
