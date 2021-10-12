using System;
namespace VideoClubManagement.Data.Entities
{
    class Article : BaseEntity<int>
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public Genre Genres { get; set; }
        public int ArticleTypeId { get; set; }
        public ArticleType ArticleTypes { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public decimal RentPerDay{ get; set; }
        public int DaysRented { get; set; }
        public decimal LateReturnFee { get; set; }
    }
}
