using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class LanguageConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            Property(l => l.ISOCode).IsRequired().HasMaxLength(5).IsFixedLength();

            HasIndex(l => l.ISOCode).IsUnique();

            Property(l => l.Description).IsRequired().HasMaxLength(30);
        }
    }
}
