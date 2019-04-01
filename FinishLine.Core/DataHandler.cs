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
            countries.Sort((x, y) => x.Name.CompareTo(y.Name));
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

        public static void SaveResults()
        {
            string filepath = "results.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Results of Race:");
            sb.Append($"Race Start: {Race.StartOfRace}".PadRight(45, ' '));
            sb.AppendLine($"Race End: {Race.EndOfRace}");
            sb.Append($"Race Winner:{Race.Runners[Race.WinningRunners[0]].Name}".PadRight(45, ' '));
            sb.AppendLine($"Winning time:{Race.GetOverallTime(Race.WinningRunners[0])}");
            sb.AppendLine("\n");
            sb.Append("Laps".PadRight(30, ' '));
            for (int i = 1; i <= Race.NumOfLaps; i++)
            {
                sb.Append(("Lap " + i).PadRight(20, ' '));
            }
            sb.Append("Overall Time".PadRight(20, ' '));
            sb.Append("\n");

            foreach (Runner runner in Race.Runners.Values)
            {
                DateTime minusTime = Race.StartOfRace;
                string MyString = runner.Name;
                sb.Append($"{runner.Name.PadRight(30, ' ')}");
                foreach (DateTime time in Race.RunnerLaps[runner.ID].Skip(1))
                {
                    sb.Append($"{time - minusTime}".PadRight(20, ' '));
                    minusTime = time;
                }
                sb.Append($"{Race.GetOverallTime(runner.ID)}\n");
            }
            File.Delete(filepath);
            File.AppendAllText(filepath, sb.ToString());

        }


    }
}
