using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emenu.forms.Conndialog;
using emenu.forms.MainWindow;

namespace emenu
{
    internal class passer
    {
        [STAThread]
        static void Main()
        {

        ApplicationConfiguration.Initialize();
        Application.Run(new MainWindow(""));
        }
    }
}
