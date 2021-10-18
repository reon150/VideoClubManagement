using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class ArticleConfiguration : EntityTypeConfiguration<Article>
    {
        public ArticleConfiguration()
        {
            Property(a => a.Title).IsRequired().HasMaxLength(100);

            Property(a => a.RentPerDay).IsRequired().HasPrecision(10, 4);

            Property(a => a.RentalDays).IsRequired();

            Property(a => a.LateReturnFee).IsRequired().HasPrecision(10, 4);
        }
    }
}
