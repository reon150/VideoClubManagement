using System;

namespace VideoClubManagement.Data.Entities
{
    public class ArticleLending : BaseEntity<int>
    {
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal AmountPerDay { get; set; }
        public string Comment { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
