using System.Diagnostics;

namespace emenu
{
    class IOProcessing
    {
        public static string ToThreeDigit(int orderID)
        {
            return String.Format("{0:D3}", orderID);
        }
        public static List<int> StringToList (string input)

        {
            var menuPoses = new List<int>();
            if (input != String.Empty)
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
    }
}