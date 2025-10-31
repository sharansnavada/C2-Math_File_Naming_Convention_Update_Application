using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Math_Naming_Convention
{
    class FileHandler
    {
        #region declaring variables
        FileNameConvention fnc = new FileNameConvention(); 
        FilesNameData fnd = new FilesNameData();
        string denom1DirPath = ""; string denom2DirPath = ""; string denom5DirPath = ""; string denom10DirPath = ""; string denom100DirPath = ""; string denom200DirPath = "";
        
        Dictionary<string, string> dict1;
        Dictionary<string, int> percentDict1;

        Dictionary<string, string> dict2;
        Dictionary<string, int> percentDict2;

        Dictionary<string, string> dict5;
        Dictionary<string, int> percentDict5;

        Dictionary<string, string> dict10;
        Dictionary<string, int> percentDict10;

        Dictionary<string, string> dict100;
        Dictionary<string, int> percentDict100;

        Dictionary<string, string> dict200;
        Dictionary<string, int> percentDict200;
        #endregion

        #region constructor
        public FileHandler(int denom)
        {
            denom1DirPath = fnd.directoryOfDenoms[0];
            denom2DirPath = fnd.directoryOfDenoms[1];
            denom5DirPath = fnd.directoryOfDenoms[2];
            denom10DirPath = fnd.directoryOfDenoms[3];
            denom100DirPath = fnd.directoryOfDenoms[4];
            denom200DirPath = fnd.directoryOfDenoms[5];

            dict1 = fnc.EditNamingConvention(fnd.Denom1MathFileName, fnd.percentInOrderOf30);
            percentDict1 = fnc.PercentCount(fnd.Denom1MathFileName, fnd.percentInOrderOf30);

            dict2 = fnc.EditNamingConvention(fnd.Denom2MathFileName, fnd.percentInOrderOf30);
            percentDict2 = fnc.PercentCount(fnd.Denom2MathFileName, fnd.percentInOrderOf30);

            dict5 = fnc.EditNamingConvention(fnd.Denom5MathFileName, fnd.percentInOrderOf30);
            percentDict5 = fnc.PercentCount(fnd.Denom5MathFileName, fnd.percentInOrderOf30);

            dict10 = fnc.EditNamingConvention(fnd.Denom10MathFileName, fnd.percentInOrderOf30);
            percentDict10 = fnc.PercentCount(fnd.Denom10MathFileName, fnd.percentInOrderOf30);

            dict100 = fnc.EditNamingConvention(fnd.Denom100MathFileName, fnd.percentInOrderOf24);
            percentDict100 = fnc.PercentCount(fnd.Denom100MathFileName, fnd.percentInOrderOf24);

            dict200 = fnc.EditNamingConvention(fnd.Denom200MathFileName, fnd.percentInOrderOf24);
            percentDict200 = fnc.PercentCount(fnd.Denom200MathFileName, fnd.percentInOrderOf24);

            switch (denom)
            {
                case 1:
                    File.Create(denom1DirPath).Close();
                    break;

                case 2:
                    File.Create(denom2DirPath).Close();
                    break;

                case 5:
                    File.Create(denom5DirPath).Close();
                    break;

                case 10:
                    File.Create(denom10DirPath).Close();
                    break;

                case 100:
                    File.Create(denom100DirPath).Close();
                    break;

                case 200:
                    File.Create(denom200DirPath).Close();
                    break;
            }   
        }
        #endregion
        #region performmathnamingconvention
        public void PerFormMathNamingConventionAndPrintInFile(int denom)
        {
            switch (denom)
            {
                case 1:
                    File.AppendAllText(denom1DirPath, "C3 Math                               C2 Math");
                    File.AppendAllText(denom1DirPath, "\n=======================================================");
                    foreach (KeyValuePair<string, string> kvp in dict1)
                    {
                        File.AppendAllText(denom1DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                    }
                    File.AppendAllText(denom1DirPath, "\n=======================================================");
                    break;

                case 2:
                    File.AppendAllText(denom2DirPath, "C3 Math                               C2 Math");
                    File.AppendAllText(denom2DirPath, "\n=======================================================");
                    foreach (KeyValuePair<string, string> kvp in dict2)
                    {
                        File.AppendAllText(denom2DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                    }
                    File.AppendAllText(denom2DirPath, "\n=======================================================");
                    break;

                case 5:
                    File.AppendAllText(denom5DirPath, "C3 Math                               C2 Math");
                    File.AppendAllText(denom5DirPath, "\n=======================================================");
                    foreach (KeyValuePair<string, string> kvp in dict5)
                    {
                        File.AppendAllText(denom5DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                    }
                    File.AppendAllText(denom5DirPath, "\n=======================================================");
                    break;

                case 10:
                    File.AppendAllText(denom10DirPath, "C3 Math                               C2 Math");
                    File.AppendAllText(denom10DirPath, "\n=======================================================");
                    foreach (KeyValuePair<string, string> kvp in dict10)
                    {
                        File.AppendAllText(denom10DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                    }
                    File.AppendAllText(denom10DirPath, "\n=======================================================");
                    break;

                case 100:
                    File.AppendAllText(denom100DirPath, "C3 Math                               C2 Math");
                    File.AppendAllText(denom100DirPath, "\n=======================================================");
                    foreach (KeyValuePair<string, string> kvp in dict100)
                    {
                        File.AppendAllText(denom100DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                    }
                    File.AppendAllText(denom100DirPath, "\n=======================================================");
                    break;

                case 200:
                    File.AppendAllText(denom200DirPath, "C3 Math                               C2 Math");
                    File.AppendAllText(denom200DirPath, "\n=======================================================");
                    foreach (KeyValuePair<string, string> kvp in dict200)
                    {
                        File.AppendAllText(denom200DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                    }
                    File.AppendAllText(denom200DirPath, "\n=======================================================");
                    break;
            }
        }
        #endregion
        #region countuniquepercents
        public void CountUniquePercentsInAllMath(int denom)
        {
            int count = 0;
            switch (denom)
            {
                case 1:
                    foreach (KeyValuePair<string, int> kvp in percentDict1)
                    {
                        File.AppendAllText(denom1DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                        count += kvp.Value;
                    }
                    File.AppendAllText(denom1DirPath, "\n total math count is " + count.ToString() );
                    break;

                case 2:
                    foreach (KeyValuePair<string, int> kvp in percentDict2)
                    {
                        File.AppendAllText(denom2DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                        count += kvp.Value;
                    }
                    File.AppendAllText(denom2DirPath, "\n total math count is " + count.ToString());
                    break;

                case 5:
                    foreach (KeyValuePair<string, int> kvp in percentDict5)
                    {
                        File.AppendAllText(denom5DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                        count += kvp.Value;
                    }
                    File.AppendAllText(denom5DirPath, "\n total math count is " + count.ToString());
                    break;

                case 10:
                    foreach (KeyValuePair<string, int> kvp in percentDict10)
                    {
                        File.AppendAllText(denom10DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                        count += kvp.Value;
                    }
                    File.AppendAllText(denom10DirPath, "\n total math count is " + count.ToString());
                    break;

                case 100:
                    foreach (KeyValuePair<string, int> kvp in percentDict100)
                    {
                        File.AppendAllText(denom100DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                        count += kvp.Value;
                    }
                    File.AppendAllText(denom100DirPath, "\n total math count is " + count.ToString());
                    break;

                case 200:
                    foreach (KeyValuePair<string, int> kvp in percentDict200)
                    {
                        File.AppendAllText(denom200DirPath, "\n" + kvp.Key + "  ----------->  " + kvp.Value);
                        count += kvp.Value;
                    }
                    File.AppendAllText(denom200DirPath, "\n total math count is " + count.ToString());
                    break;
            }
        }
        #endregion
    }
}
