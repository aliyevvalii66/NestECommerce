﻿using NestECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Application.Repositories.ProductRep
{
	public interface IProductReadRepository : IReadRepository<Product>
	{
	}
}
