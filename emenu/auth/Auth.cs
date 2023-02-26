using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace emenu_csharp
{
    internal class Auth
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\electromenu";

        public void SaveProfile(string hostname, string port, string username, string password, string db_name)
        {
            string text = $"{hostname}/{port}/{username}/{password}/{db_name}";

            if (!(Directory.Exists(path)))
            {
                Directory.CreateDirectory(path);
            }

            if (Directory.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter($"{path}\\profiles.txt", true, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(text);
                }
            }
        }

        public void LoadProfile()
        {
            using (StreamReader reader = new StreamReader($"{path}\\profiles.txt"))
            {
                string? line; 
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line); //попробовать начать вывод в хешсет или другую коллекцию
                }
            }
        }
    }
}
