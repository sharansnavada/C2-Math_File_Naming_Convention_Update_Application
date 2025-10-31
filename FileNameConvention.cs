using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Naming_Convention
{
      class FileNameConvention
    {
        Dictionary<string,string> dict = new Dictionary<string, string>();
        FilesNameData fnd = new FilesNameData();
        Dictionary<string, int> percentCount = new Dictionary<string, int>();

        public Dictionary<string,string> EditNamingConvention(List<string> filesName,List<int> percentInOrder1)
        {
            dict = new Dictionary<string, string>();

            for (int i = 0 ; i < filesName.Count; i++)
            {
                string[] splittedData = filesName[i].Split('.');

                string c2Name = splittedData[0] + "." + splittedData[2].TrimStart('l') + "." + percentInOrder1[i].ToString() + "." + splittedData[3] + "." + splittedData[4] + "." +
                                "cSM2054" + "." + splittedData[1];

                dict[filesName[i]] = c2Name;
            }
            return dict;
        }

        public Dictionary<string, int> PercentCount(List<string> filesName, List<int> percentInOrder1)
        {
            percentCount = new Dictionary<string, int>();

            for (int i = 0; i < filesName.Count; i++)
            {
                if (!percentCount.ContainsKey(percentInOrder1[i].ToString()))
                    percentCount[percentInOrder1[i].ToString()] = 0;
                percentCount[percentInOrder1[i].ToString()]++;
            }
            return percentCount;
        }
    }
}
