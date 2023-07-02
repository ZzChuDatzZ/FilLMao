namespace Demo_Project
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
            DataContainer.player = new Player();
            ApplicationConfiguration.Initialize();
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.Run(new Login_Form());
        }
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            DataContainer.tcpClient.Close();
            DataContainer.ns.Close();
        }
    }
}