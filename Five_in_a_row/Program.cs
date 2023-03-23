using GobangLibrary;

namespace Five_in_a_row
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2());

            Form1 F1 = new Form1();
            Form2 F2 = new Form2();
            //Application.Run(F1);

            GameManager GM = new GameManager(F1, F2);
            
        }
    }
}