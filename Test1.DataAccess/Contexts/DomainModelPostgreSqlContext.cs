using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Test1.Library.DataEntities;
using Test1.Library.Interfaces;

namespace Test1.DataAccess.Contexts
{
    public class DomainModelPostgreSqlContext : DbContext, IDomainModelContext
    {
        private string _connectionString;
        public string ConnectionString => _connectionString;

        public DomainModelPostgreSqlContext(DbContextOptions<DomainModelPostgreSqlContext>options):base(options)
        {

        }

        //public DomainModelPostgreSqlContext(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}
       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(_connectionString);
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            AddTimeStamps<CreatedModifiedEntity>();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            AddTimeStamps<CreatedModifiedEntity>();
            return base.SaveChangesAsync(cancellationToken);
        }

        public EntityState GetEntityState(object value)
        {
            return Entry(value).State;
        }

        public void SetEntityPropertyModified(object user, string propertyName)
        {
            Entry(user).Property(propertyName).IsModified = true;
        }

        public void SetEntityState(object value, EntityState entityState)
        {
            Entry(value).State = entityState;
        }

        private void AddTimeStamps<T>() where T : CreatedModifiedEntity
        {
            //var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            var entities =
                ChangeTracker.Entries<T>()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);


            // if we later save userid
            /*
            var currentUsername = !string.IsNullOrEmpty(System.Web.HttpContext.Current?.User?.Identity?.Name)
                ? HttpContext.Current.User.Identity.Name
                : "Anonymous";
            */

            foreach (var entity in entities)
            {
                var cremodEntity = (CreatedModifiedEntity)entity.Entity;
                if (entity.State == EntityState.Added)
                {
                    if (cremodEntity.DateCreated.Year == 1)
                    {
                        cremodEntity.DateCreated = DateTime.UtcNow;
                    }
                    // cremodEntity.UserCreated = currentUsername;
                }

                cremodEntity.DateModified = DateTime.UtcNow;
                // cremodEntity.UserModified = currentUsername;
            }

        }


    }
}
