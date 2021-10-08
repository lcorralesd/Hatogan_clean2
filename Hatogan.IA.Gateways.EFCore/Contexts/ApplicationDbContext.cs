using Hatogan.EB.Domain.Common;
using Hatogan.EB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hatogan.IA.Gateways.EFCore.Contexts
{
    public  class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; } = default!;
        public DbSet<Breed> Breeds { get; set; } = default!;
        public DbSet<Category> Categories {  get; set; } = default!;
        public DbSet<Farm> Farms {  get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            BeforeSave();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void BeforeSave()
        {
            foreach (var auditableEntity in ChangeTracker.Entries<AuditableEntity>())
            {
                if (auditableEntity.State is EntityState.Added or EntityState.Modified)
                {
                    var date = DateTime.UtcNow;
                    var user = "system";

                    auditableEntity.Entity.UpdatedOn = date;
                    auditableEntity.Entity.UpdatedBy = user;

                    if (auditableEntity.State == EntityState.Added)
                    {
                        auditableEntity.Entity.CreatedOn = date;
                        auditableEntity.Entity.CreatedBy = user;
                    }
                    else
                    {
                        auditableEntity.Property(x => x.CreatedOn).IsModified = false;
                        auditableEntity.Property(x => x.CreatedBy).IsModified = false;
                    }
                }
            }
        }

    }
}
