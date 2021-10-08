using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Domain.Common
{
    public abstract class AuditableEntity
    {
        public string CreatedBy { get; set; } = default!;
        public DateTimeOffset CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
    }
}
