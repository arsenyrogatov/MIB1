namespace MIB1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            PasswordsLogins.Init();
            Application.Run(new LoginForm());
            Application.ApplicationExit += (s, e) => PasswordsLogins.Save();
        }
    }
}