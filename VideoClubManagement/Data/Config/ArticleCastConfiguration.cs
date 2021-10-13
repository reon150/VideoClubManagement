using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class ArticleCastConfiguration : EntityTypeConfiguration<ArticleCast>
    {
        public ArticleCastConfiguration()
        {
            HasKey(ac => ac.Id);
        }
    }
}
