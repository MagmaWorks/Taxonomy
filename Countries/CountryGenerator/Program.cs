﻿namespace CountryGenerator
{
    public class Program
    {
        public static void Main()
        {
            // Relative path to data
            string path = "../../../CountriesData.csv";
            // read data, skip header row
            List<CsvValues> values = File.ReadAllLines(path).Skip(1)
                                     .Select(v => CsvValues.FromCsv(v))
                                     .ToList();

            var directory = Directory.GetParent(path).Parent;
            path = Path.Combine(directory.FullName, "Countries", "AutoGenerated");
            Directory.CreateDirectory(path);
            foreach (CsvValues v in values)
            {
                ClassWriter.WriteClass(v, path);
            }
        }
    }
}