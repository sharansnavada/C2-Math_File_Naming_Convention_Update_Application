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
            FileHandler fd1 = new FileHandler(1);
            fd1.PerFormMathNamingConventionAndPrintInFile(1);
            fd1.CountUniquePercentsInAllMath(1);
        }
    }
}
