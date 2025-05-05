using DraftAboutReserveEngineer.Models;

namespace DraftAboutReserveEngineer
{
    public static class GlobalUser
    {
        public static User CurrentUser { get; internal set; }
    }
}