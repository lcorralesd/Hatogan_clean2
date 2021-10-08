using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.DTOs.Animals
{
    public class AnimalDTO
    {
        public int Id { get; set; }
        public string Code { get; set; } = default!;
        public string? EarTag { get; set; }
        public string? Name { get; set; }
        public string? Iron { get; set; }
        public string Sex { get; set; } = default!;
        public string Status { get; set; } = default!;
        public string Farm { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string Breed { get; set; } = default!;
        public string? Color { get; set; }

        public int AgeDays { get; private set; }

        public string? AgeLong { get; private set;  }
        

        public DateTime BirthDate { get; set; }
        public double BirthWeight { get; set; } = 0;
        public DateTime AdmissionDate { get; set; }
        public double IncomeWeight { get; set; } = 0;
        public string? Dam { get; set; }
        public string? Sire { get; set; }
        public string? Remark { get; set; }
        public string? ImageUrl { get; set; }
    }
}
