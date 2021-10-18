using System.Collections.Generic;

namespace VideoClubManagement.Data.Entities
{
    public class Genre : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int? ParentId { get; set; }
        public Genre Parent { get; set; }

        public List<Genre> Children { get; set; }

        public List<Article> Articles { get; set; }
    }
}
