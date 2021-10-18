using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class LegalPersonTypeConfiguration : EntityTypeConfiguration<LegalPersonType>
    {
        public LegalPersonTypeConfiguration()
        {
            Property(lpt => lpt.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(lpt => lpt.Name) .IsRequired().HasMaxLength(50);

            Property(lpt => lpt.Description).IsRequired().HasMaxLength(500);
        }
    }
}
