using Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string resourceFolder = "Resources";
            string fileInput = Path.Combine(resourceFolder, "scorecard.txt");
            string fileOutput = Path.Combine(resourceFolder, "default.xml");
            List<Country> countries = new List<Country>();
            using (StreamReader sr = new StreamReader(new FileStream(fileInput, FileMode.Open, FileAccess.Read)))
            {
                string[] header = sr.ReadLine().Split('\t');
                int countryIndex = Array.IndexOf(header, Utils.CountryParam.Text);
                int[] categoryIndexes = new int[Utils.Categories.Length];
                for (int i = 0; i < Utils.Categories.Length; i++)
                {
                    categoryIndexes[i] = Array.IndexOf(header, Utils.Categories[i].Text);
                }
                string line;

                while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                {
                    string[] splt = line.Split('\t');
                    string name = splt[countryIndex];
                    Grade[] grades = new Grade[categoryIndexes.Length];
                    for (int i=0; i<categoryIndexes.Length; i++)
                    {
                        grades[i] = new Grade(splt[categoryIndexes[i]]);
                    }
                    countries.Add(new Country(name, grades));
                }
            }
            using (StreamWriter sw = new StreamWriter(new FileStream(fileOutput, FileMode.Create, FileAccess.Write)))
            {
                Utils.Serialize(sw, countries.ToArray());
            }

        }
    }
}
