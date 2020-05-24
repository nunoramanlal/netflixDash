using System;
using System.Collections.Generic;
using System.IO;

namespace ViewingInsights.Services.FileReader
{
    public class CSVFileReader
    {
        public void ReadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            reader.ReadLine();
            Dictionary<string, string> viewingData = new Dictionary<string, string>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                viewingData[values[0]] = values[1];
            }

            foreach (KeyValuePair<string, string> kvp in viewingData)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

        }
    }
}
