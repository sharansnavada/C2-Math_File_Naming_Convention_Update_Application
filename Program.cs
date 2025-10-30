using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Math_Naming_Convention
{
    class Program
    {
        static void Main(string[] args)
        {
            FileNameConvention fnc = new FileNameConvention();
            FilesNameData fnd = new FilesNameData();

            Dictionary<string, string> dict = fnc.EditNamingConvention(fnd.filesName, fnd.percentInOrder);
            Dictionary<string, int> percentDict = fnc.PercentCount(fnd.filesName, fnd.percentInOrder);

            string path = "C:/sandbox/Games/EurekaNMoreBlastin_NAM_Titan_up/swapfiles/2_EurekaNMoreBlastin_Server/server/GameData/Math/2/new_math_name.txt";
            File.Create(path).Close();

            foreach(KeyValuePair<string, string> kvp in dict)
            {
                File.AppendAllText(path, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
            }

            foreach (KeyValuePair<string, int> kvp in percentDict)
            {
                File.AppendAllText(path, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
            }

        }
    }
}
