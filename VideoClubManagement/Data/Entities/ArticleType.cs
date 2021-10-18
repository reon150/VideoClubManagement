using System.Collections.Generic;

namespace VideoClubManagement.Data.Entities
{
    public class ArticleType : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Article> Articles { get; set; }
    }
}
