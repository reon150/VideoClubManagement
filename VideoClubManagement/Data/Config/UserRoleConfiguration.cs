using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            Property(ur => ur.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(ur => ur.Name).IsRequired().HasMaxLength(50);

            Property(ur => ur.Description).IsRequired().HasMaxLength(500);
        }
    }
}
