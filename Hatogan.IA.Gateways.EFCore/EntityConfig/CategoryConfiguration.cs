using Hatogan.EB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Gateways.EFCore.EntityConfig
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(20);
            builder.HasData(
               new Category { Id = 1, Name = "Crias", Since = 0, Until = 240 },
                new Category { Id = 2, Name = "Novillas Destete", Since = 240, Until = 365  },
                new Category { Id = 3, Name = "Mautes Destete", Since = 240, Until = 365 },
                new Category { Id = 4, Name = "Novillas de Levante", Since = 365, Until = 600 },
                new Category { Id = 5, Name = "Maute de Levante", Since = 365, Until = 600 },
                new Category { Id = 6, Name = "Novillas de Vientre", Since = 600, Until = 1080 },
                new Category { Id = 7, Name = "Maute de Vientre", Since = 600, Until = 1080 },
                new Category { Id = 8, Name = "Vacas", Since = 1080, Until = 3600 },
                new Category { Id = 9, Name = "Toros", Since = 1080, Until = 3600 });
        }
    }
}
