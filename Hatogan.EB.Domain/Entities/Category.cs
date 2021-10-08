using Hatogan.EB.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Domain.Entities
{
    public class Category 
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Since { get; set; }
        public int Until { get; set; }

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();
    }
}
