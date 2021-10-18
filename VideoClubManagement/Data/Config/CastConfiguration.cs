using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class CastConfiguration : EntityTypeConfiguration<Cast>
    {
        public CastConfiguration()
        {
            Property(c => c.FirstName).IsRequired().HasMaxLength(100);

            Property(c => c.LastName).IsRequired().HasMaxLength(100);
        }
    }
}
