using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class ArticleTypeConfiguration : EntityTypeConfiguration<ArticleType>
    {
        public ArticleTypeConfiguration()
        {
            Property(at => at.Name).IsRequired().HasMaxLength(50);

            Property(at => at.Description).IsRequired().HasMaxLength(500);
        }
    }
}
