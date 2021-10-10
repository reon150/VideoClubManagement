using System.Collections.Generic;
using VideoClubManagement.Data.Enums;

namespace VideoClubManagement.Data.Entities
{
    public class LegalPersonType : BaseEntity<LegalPersonTypeId>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Client> Users { get; set; }
    }
}
