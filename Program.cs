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
            FilesNameData fnd = new FilesNameData();
            FileHandler fd1 = new FileHandler(1);
            fd1.MoveMathFilesToNewRenamedFile(fnd.directoryOfDenoms[0].TrimEnd("/new_math_name.txt".ToCharArray()),fd1.dict1);

            FileHandler fd2 = new FileHandler(2);
            fd2.MoveMathFilesToNewRenamedFile(fnd.directoryOfDenoms[1].TrimEnd("/new_math_name.txt".ToCharArray()), fd2.dict2);

            FileHandler fd5 = new FileHandler(5);
            fd5.MoveMathFilesToNewRenamedFile(fnd.directoryOfDenoms[2].TrimEnd("/new_math_name.txt".ToCharArray()), fd5.dict5);

            FileHandler fd10 = new FileHandler(10);
            fd10.MoveMathFilesToNewRenamedFile(fnd.directoryOfDenoms[3].TrimEnd("/new_math_name.txt".ToCharArray()), fd10.dict10);

            FileHandler fd100 = new FileHandler(100);
            fd100.MoveMathFilesToNewRenamedFile(fnd.directoryOfDenoms[4].TrimEnd("/new_math_name.txt".ToCharArray()), fd100.dict100);

            FileHandler fd200 = new FileHandler(200);
            fd200.MoveMathFilesToNewRenamedFile(fnd.directoryOfDenoms[5].TrimEnd("/new_math_name.txt".ToCharArray()), fd200.dict200);

            //FileHandler fd1 = new FileHandler(1);
            //fd1.PerFormMathNamingConventionAndPrintInFile(1);
            //fd1.CountUniquePercentsInAllMath(1);

            //FileHandler fd2 = new FileHandler(2);
            //fd2.PerFormMathNamingConventionAndPrintInFile(2);
            //fd2.CountUniquePercentsInAllMath(2);

            //FileHandler fd5 = new FileHandler(5);
            //fd5.PerFormMathNamingConventionAndPrintInFile(5);
            //fd5.CountUniquePercentsInAllMath(5);

            //FileHandler fd10 = new FileHandler(10);
            //fd10.PerFormMathNamingConventionAndPrintInFile(10);
            //fd10.CountUniquePercentsInAllMath(10);

            //FileHandler fd100 = new FileHandler(100);
            //fd100.PerFormMathNamingConventionAndPrintInFile(100);
            //fd100.CountUniquePercentsInAllMath(100);

            //FileHandler fd200 = new FileHandler(200);
            //fd200.PerFormMathNamingConventionAndPrintInFile(200);
            //fd200.CountUniquePercentsInAllMath(200);
        }
    }
}
