using KBCsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class DataHandler
    {
        

        public static List<Country> LoadCountries(string filepath)
        {
            List<Country> countries = new List<Country>();
            using (var streamReader = new StreamReader(filepath))
            using (var reader = new CsvReader(streamReader))
            {
                reader.ValueSeparator = ';';
                reader.ReadHeaderRecord();

                while (reader.HasMoreRecords)
                {
                    var dataRecord = reader.ReadDataRecord();

                    countries.Add(new Country() { Code = dataRecord["CountryCode"], Name = dataRecord["EnglishShortName"] });
                }
            }
            //countries.Sort(item=>item.Name);
            return countries;
        }

        public static void SaveRunners(string filePath)
        {
            File.Delete(filePath);
            foreach (Runner runner in Race.Runners.Values)
            {
                File.AppendAllText(filePath, runner.ToString() + "\n");
            }
        }

        public static Dictionary<int, Runner> LoadRunners (string filePath)
        {
            Dictionary<int, Runner> runners = new Dictionary<int, Runner>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('\t');
                
                runners.Add(key: int.Parse(parts[0]),
                            value: new Runner() { ID = int.Parse(parts[0]),Name = parts[1], Country = parts [2], Age = int.Parse(parts[3]), Gender = parts[4]});
            }
            return runners;
        }


    }
}
