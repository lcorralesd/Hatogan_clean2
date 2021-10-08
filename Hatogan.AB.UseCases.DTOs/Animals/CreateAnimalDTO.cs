using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.DTOs.Animals
{
    public class CreateAnimalDTO
    {
        public string Code { get; set; } = default!;
        public string? EarTag { get; set; }
        public string? Name { get; set; }
        public string? Iron { get; set; }
        public string Sex { get; set; } = default!;
        public string Status { get; set; } = default!;
        public int FarmId { get; set; }
        public int CategoryId { get; set; }
        public int BreedId { get; set; }
        public string? Color { get; set; }
        public DateTime BirthDate { get; set; }
        public double BirthWeight { get; set; } = 0;
        public DateTime AdmissionDate { get; set; }
        public double IncomeWeight { get; set; } = 0;
        public string? Remark { get; set; }
        public string? ImageUrl { get; set; }
    }
}
