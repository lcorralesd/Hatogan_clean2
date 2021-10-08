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
    public class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(20);
            builder.HasIndex(ix => ix.Name).IsUnique();
            builder.HasData(
               new Breed { Id = 1, Name = "-No Asignado-", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 2, Name = "Angus", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 3, Name = "Angus Negro", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 4, Name = "Angus Rojo", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 5, Name = "Ayrshire", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 6, Name = "Bom", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 7, Name = "Brahman", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 8, Name = "Brangus", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 9, Name = "Casanareño", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 10, Name = "Cebu", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 11, Name = "Charolais", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 12, Name = "Chino Santandereano", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 13, Name = "Costeño con Cuernos", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 14, Name = "Criollo", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 15, Name = "Guzerat", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 16, Name = "Gyr", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 17, Name = "Harton del valle", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 18, Name = "Holstein", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 19, Name = "Indubrasil", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 20, Name = "Jersey", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 21, Name = "Limousin", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 22, Name = "Lucerna", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 23, Name = "Nelore", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 24, Name = "Normando", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 25, Name = "Pardo", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 26, Name = "Romosinuano", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 27, Name = "Sanmartinero", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 28, Name = "Simmental", CreatedBy = "system", CreatedOn = DateTimeOffset.Now },
                new Breed { Id = 29, Name = "Velasquez", CreatedBy = "system", CreatedOn = DateTimeOffset.Now });
        }
    }
}
