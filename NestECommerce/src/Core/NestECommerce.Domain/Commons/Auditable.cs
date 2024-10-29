using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Domain.Commons
{
	public abstract class Auditable : BaseEntity
	{
        public DateTime CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
        public string CreatedBy { get; set; }
        public string? EditedBy { get; set; }
    }
}
