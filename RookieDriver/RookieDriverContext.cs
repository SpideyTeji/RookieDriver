namespace RookieDriver
{
    public class RookieDriverContext
    {
        public static string LoggedInUsername { get; set; }

        public static bool IsUserLoggedIn { get; set; }

        public static bool IsTestStarted { get; set; }

        public static bool InTutorial { get; set; }
    }
}
