using Microsoft.EntityFrameworkCore;
using NestECommerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Application.Repositories
{
	public interface IRepository<T> where T : Auditable
	{
        public DbSet<T> Table { get; }
    }
}
