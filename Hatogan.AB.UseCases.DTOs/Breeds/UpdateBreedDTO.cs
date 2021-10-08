using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.DTOs.Breeds
{
    public class UpdateBreedDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
