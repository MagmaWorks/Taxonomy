using CatalogueGenerator.Utilities;

namespace CatalogueProfileGenerator
{
    public class Program
    {
        private static string _namespace = "MagmaWorks.Taxonomy.Profiles";
        public static void Main()
        {
            ConvertEuropean();
            ConvertAmerican();
        }

        private static void ConvertEuropean()
        {
            // Relative path to data
            string path = $"../../../EN10365-2017.csv";
            // read data, skip header row
            List<CsvValues> values = File.ReadAllLines(path).Skip(1)
                                     .Select(v => CsvValues.FromEuropeanCsv(v))
                                     .ToList();
            GenerateFiles(values, "European");
        }

        private static void ConvertAmerican()
        {
            // Relative path to data
            string path = $"../../../aisc-shapes-database-v16.0.csv";
            // read data, skip header row
            List<CsvValues> values = File.ReadAllLines(path).Skip(1)
                                     .Select(v => CsvValues.FromAmericanCsv(v))
                                     .ToList();
            GenerateFiles(values, "American");
        }

        private static void GenerateFiles(List<CsvValues> values, string catalogue)
        {
            string path = $"../../../EN10365-2017.csv";
            DirectoryInfo? directory = Directory.GetParent(path).Parent;
            path = Path.Combine(directory.FullName, "CatalogueProfiles", catalogue, "Profiles");
            Directory.CreateDirectory(path);

            var enums = new EnumClassProperties(_namespace, catalogue);
            var utility = new UtilityClassProperties(_namespace, catalogue);

            foreach (CsvValues v in values)
            {
                string className = CatalogueClassWriter.GenerateClass(v, path, _namespace);
                enums.AppendEnum(className);
                utility.AppendType(className);
            }

            path = Path.Combine(directory.FullName, "CatalogueProfiles", catalogue);
            enums.WriteClassToFile(path);
            utility.WriteClassToFile(path);
        }
    }
}
