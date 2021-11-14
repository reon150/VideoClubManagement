using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=VideoClubManagement") { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCast> ArticleCasts { get; set; }
        public DbSet<ArticleLending> ArticleLendings { get; set; }
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LegalPersonType> LegalPersonTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShiftWork> ShiftWorks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
   
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            UpdateEntriesEntities();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            UpdateEntriesEntities();
            return await base.SaveChangesAsync();
        }

        private void UpdateEntriesEntities()
        {
            var changeSet = ChangeTracker.Entries<ITrackable>();

            if (changeSet != null)
            {
                foreach (var entry in changeSet.Where(c => c.State != EntityState.Unchanged))
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.Entity.CreatedDate = DateTime.Now;
                            entry.Entity.LastUpdatedDate = DateTime.Now;
                            break;

                        case EntityState.Modified:
                            entry.Property(x => x.CreatedDate).IsModified = false;
                            entry.Entity.LastUpdatedDate = DateTime.Now;
                            break;
                    }
                }
            }
        }
    }
}
