//using emenu.forms.MainWindow;
//using System.Diagnostics;
//using emenu.forms.Conndialog;

//namespace emenu
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
//            Application.Run(new Conndialog());
//            string? connString = null;
//            if (Conndialog.conndialogReady) //getting SQL params if login passed
//            {
//                connString = Conndialog.GetParams();
//            }
//            else
//            {
//                Debug.Write("Conndialog processing done");
//                Environment.Exit(0);
//            }
//            Application.Run(new MainWindow(connString));
//        }
//    }
//}