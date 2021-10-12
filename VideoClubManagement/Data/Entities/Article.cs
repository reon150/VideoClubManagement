using System;
namespace VideoClubManagement.Data.Entities
{
    class Article : BaseEntity<int>
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public ArticleType ArticleType { get; set; }
        public Language Language { get; set; }
        public decimal RentPerDay{ get; set; }
        public int DaysRented { get; set; }
        public decimal LateReturnFee { get; set; }
    }
}
