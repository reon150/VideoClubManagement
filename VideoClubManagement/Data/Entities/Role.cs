using System.Collections.Generic;

namespace VideoClubManagement.Data.Entities
{
    public class Role : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ArticleCast> ArticleCasts { get; set; }
    }
}
