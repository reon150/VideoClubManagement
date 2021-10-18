namespace VideoClubManagement.Data.Entities
{
    public class ArticleCast : BaseEntity<int>
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int CastId { get; set; }
        public Cast Cast { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
