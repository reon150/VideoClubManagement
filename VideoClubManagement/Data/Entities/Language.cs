using System.Collections.Generic;

namespace VideoClubManagement.Data.Entities
{ 
	public class Language : BaseEntity<int>
	{
		public string ISOCode { get; set; }
		public string Description { get; set; }

        public List<Article> Articles { get; set; }
    }
}
