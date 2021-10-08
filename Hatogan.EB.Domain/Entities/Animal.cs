using Hatogan.EB.Domain.Common;
using Hatogan.EB.Domain.Enums;
using Hatogan.EB.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Domain.Entities
{
    public class Animal : AuditableEntity
    {
        public int Id { get; set; }
        public string Code { get; set; } = default!;
        public string? EarTag { get; set; }
        public string? Name { get; set; }
        public string? Iron { get; set; }
        public Sex Sex { get; set; }
        public Status Status { get; set; }
        public int FarmId { get; set; }
        public Farm Farm { get; set; } = default!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        public int BreedId { get; set; }
        public Breed Breed { get; set; } = default!;
        public string? Color { get; set; }

        private int _ageDays;

        public int AgeDays
        {
            get
            {
                _ageDays = Utils.CalculateAgeDays(BirthDate);
                return _ageDays;
            }
        }

        private string? _agelong;

        public string? AgeLong
        {
            get
            {
                _agelong = Utils.CalculateLongAge(BirthDate, DateTime.Now);
                return _agelong;
            }
        }

        public DateTime BirthDate { get; set; }
        public double BirthWeight { get; set; } = 0;
        public DateTime AdmissionDate { get; set; }
        public double IncomeWeight { get; set; } = 0;
        public int? DamId { get; set; }
        public Animal? Dam { get; set; }
        public int? SireId { get; set; }
        public Animal? Sire { get; set; }
        public string? Remark { get; set; }
        public string? ImageUrl { get; set; }

        public List<Animal> DamPups { get; set; } = new List<Animal>();
        public List<Animal> SirePups { get; set; } = new List<Animal>();

    }
}
