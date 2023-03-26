using System.Diagnostics;
using System.Resources;

namespace emenu
{
    class IOProcessing
    {
        public static string ToThreeDigit(int orderID)
        {
            return string.Format("{0:D3}", orderID);
        }
        public static List<int> StringToList (string input)

        {
            var menuPoses = new List<int>();
            if (input != string.Empty)
            {
                string[] stringMenuPoses = input.Split(',', ' ', '.', '-', ';', ':');
                foreach (string item in stringMenuPoses)
                {
                    if (int.TryParse(item, out int x) && x>0) menuPoses.Add(x);
                }
            }
            else MessageBox.Show("String is empty");
            return menuPoses;
        }
        public static string ListToString(List<int> input)
        {
            string str = string.Empty;
            foreach (var item in input)
            {
                str+= $"{item} ";
            }
            return str;
        }
        public static string MenuIDsToNames(List<int> input)
        {
            string output = string.Empty;
            Dictionary <int, string> menuIDsToNamesList = Menu.IDsNamesDict;
            foreach (int item in input)
            {
                output += $"{menuIDsToNamesList[item]}, ";
            }

            return output = output.TrimEnd(' ', ',');
        }
    }
}