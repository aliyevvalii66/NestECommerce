﻿using NestECommerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Application.Utils
{
	public class PagedResponse<T>
		where T : Auditable
	{
		public IEnumerable<T> Data { get; set; }
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
		public int TotalRecords { get; set; }
		public int TotalPages => (int)Math.Ceiling((double)TotalRecords / PageSize);
	}
}
