using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.IdentificationNumber).IsRequired().HasMaxLength(11).IsFixedLength();
            HasIndex(u => u.IdentificationNumber).IsUnique();

            Property(u => u.UserName).IsRequired().HasMaxLength(20);
            HasIndex(u => u.UserName).IsUnique();

            Property(u => u.Email).IsRequired().HasMaxLength(20);
            HasIndex(u => u.Email).IsUnique();

            Property(u => u.Password).IsRequired().HasMaxLength(50);
        }
    }
}
