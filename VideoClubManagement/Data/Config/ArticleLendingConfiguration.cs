using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class ArticleLendingConfiguration : EntityTypeConfiguration<ArticleLending>
    {
        public ArticleLendingConfiguration()
        {
            Property(al => al.DueDate).IsRequired().HasColumnType("date");

            Property(al => al.ReturnDate).HasColumnType("date");

            Property(al => al.AmountPerDay).IsRequired().HasPrecision(10, 4);

            Property(al => al.Comment).IsRequired().HasMaxLength(1000);
        }
    }
}
