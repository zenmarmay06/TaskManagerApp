using TaskManager.Data.Database;
namespace TaskManager.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
     
            DatabaseInitializer.Initialize();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

        }
    }
}