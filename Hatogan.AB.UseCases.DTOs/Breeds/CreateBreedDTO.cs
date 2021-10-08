using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.DTOs.Breeds
{
    public record CreateBreedDTO
    {
        public string Name { get; init; } = default!;
    }
}
