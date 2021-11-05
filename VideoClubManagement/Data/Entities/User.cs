using VideoClubManagement.Data.Enums;

namespace VideoClubManagement.Data.Entities
{
    public class User : BaseEntity<int>
    {
        public string IdentificationNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserRoleId UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
