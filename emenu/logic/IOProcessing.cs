using System.Diagnostics;

namespace emenu
{
    class IOProcessing
    {
        /// <summary>
        /// Convert "1" to "001".
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <returns></returns>
        public static string ToThreeDigit(int orderNumber)
        {
            return String.Format("{0:D3}", orderNumber);
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
        
    }
}