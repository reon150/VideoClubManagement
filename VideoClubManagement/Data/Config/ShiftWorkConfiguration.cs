using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class ShiftWorkConfiguration : EntityTypeConfiguration<ShiftWork>
    {
        public ShiftWorkConfiguration()
        {
            Property(r => r.Description).IsRequired().HasMaxLength(50);
        }
    }
}
