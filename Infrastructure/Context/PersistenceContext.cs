using Domain.Entities;
using Domain.Entities.Base;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Context
{
    public class PersistenceContext : DbContext
    {

        private readonly IConfiguration _config;

        public PersistenceContext(DbContextOptions<PersistenceContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<GymOwner> GymOwners { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Routine> Routines { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<CustomerPlan> CustomerPlans { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        

        public async Task CommitAsync()
        {
            await SaveChangesAsync().ConfigureAwait(false);
        }

        protected override void OnModelCreating(ModelBuilder? modelBuilder)
        {
            if (modelBuilder == null)
            {
                return;
            }
            
            modelBuilder.AppendGlobalQueryFilter<ISoftDelete>(s => s.DeletedOn == null);
            modelBuilder.HasDefaultSchema(_config.GetValue<string>("SchemaName"));

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var t = entityType.ClrType;
                if (!typeof(DomainEntity).IsAssignableFrom(t)) continue;
                modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedOn").HasDefaultValueSql("GETDATE()");
                modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModifiedOn").HasDefaultValueSql("GETDATE()");
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
