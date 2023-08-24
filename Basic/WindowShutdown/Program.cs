namespace WindowShutdown
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
            //FormNeatMode formNeatMode = null;
            //FormFullMode formFullMode = null;
            ApplicationConfiguration.Initialize();
            //Application.Run(new formWindowShutdown(ref formFullMode,ref formNeatMode));
            Application.Run(new FormWindowShutdown());
            
        }
    }
}