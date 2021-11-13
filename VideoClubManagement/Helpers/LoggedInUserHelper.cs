using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Helpers
{
    public static class LoggedInUserHelper
    {
        private static User _user = null;

        public static User GetLoggedUser() => _user;

        public static void SetLoggedUser(User user) => _user = user;
    }
}
