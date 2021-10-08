using Hatogan.EB.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Domain.Entities
{
    public class Farm : AuditableEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Phone { get; set; } = default!;

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();
    }
}
