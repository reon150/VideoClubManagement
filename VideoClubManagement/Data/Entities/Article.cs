using System.Collections.Generic;

namespace VideoClubManagement.Data.Entities
{
    public class Article : BaseEntity<int>
    {
        public string Title { get; set; }
        public decimal RentPerDay{ get; set; }
        public int RentalDays { get; set; }
        public decimal LateReturnFee { get; set; }

        public int ArticleTypeId { get; set; }
        public ArticleType ArticleType { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public List<Genre> Genres { get; set; }
        public List<ArticleCast> ArticleCasts { get; set; }
    }
}
