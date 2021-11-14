using System.Collections.Generic;
using VideoClubManagement.Data.Enums;

namespace VideoClubManagement.Data.Entities
{
    public class UserRole : BaseEntity<UserRoleId>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> Users { get; set; }
    }
}
