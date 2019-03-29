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
    }
}
