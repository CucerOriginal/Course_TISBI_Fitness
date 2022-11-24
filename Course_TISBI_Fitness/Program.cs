using Course_TISBI_Fitness.MainOffice;

namespace Course_TISBI_Fitness
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ChoiceOffice());
        }
    }
}