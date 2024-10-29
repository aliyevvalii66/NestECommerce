using NestECommerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Domain.Entities
{
	public class Product : Auditable
	{
        public string Name { get; set; }



        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
