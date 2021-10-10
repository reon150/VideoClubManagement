using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base()
        {
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
            var changeSet = ChangeTracker.Entries<BaseEntity>();

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
