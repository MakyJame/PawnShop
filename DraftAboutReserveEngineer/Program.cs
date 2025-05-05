namespace DraftAboutReserveEngineer
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForm());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                var loginForm = new LoginForm();
                var result = loginForm.ShowDialog();

                if (result != DialogResult.OK)
                    break;

                if (GlobalUser.CurrentUser.Role == "admin")
                {
                    var adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                else if (GlobalUser.CurrentUser.Role == "staff")
                {
                    var staffForm = new Form2();
                    staffForm.ShowDialog();
                }

                GlobalUser.CurrentUser = null;
            }
        }
    }
}