using NestECommerce.Application.Utils;
using NestECommerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Application.Repositories
{
	public interface IReadRepository <T> : IRepository<T> where T :Auditable
	{
		Task<T> GetByIdAsync(Guid id);
		IQueryable<T> GetAll();
		Task<PagedResponse<T>> GetPagedAsync(PaginationParameters paginationParameters);
	}
}
