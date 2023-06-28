namespace Integral_Figures
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
            MessageBox.Show("Перед использованием приложения настоятельно рекомендуем прочесть правила использования");
            Application.Run(new Menu());
        }
    }
}