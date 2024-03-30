using System.Text;
using CatalogueGenerator.Utilities;

namespace CatalogueProfileGenerator
{
    public class Program
    {
        private static string _namespace = "MagmaWorks.Taxonomy.Profiles";
        public static void Main()
        {
            ConvertEuropean();
        }

        private static void ConvertEuropean()
        {
            // Relative path to data
            string path = $"../../../EN10365-2017.csv";
            // read data, skip header row
            List<CsvValues> values = File.ReadAllLines(path).Skip(1)
                                     .Select(v => CsvValues.FromEuropeanCsv(v))
                                     .ToList();
            string catalogue = "European";
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

//            StringBuilder enums = new StringBuilder();
//            enums.AppendLine($@"namespace {_namespace}
//{{
//    public enum {catalogue}
//    {{");
//            StringBuilder utility = new StringBuilder();
//            utility.AppendLine($@"namespace {_namespace}
//{{
//    public partial class Utility
//    {{
//        public static ICatalogue GetCatalogue({catalogue} {catalogue.ToLower()})
//        {{
//            return {catalogue.ToLower()} switch
//            {{");

//            foreach (CsvValues v in values)
//            {
//                CatalogueClassWriter.GenerateClass(v, path, _namespace);
//                string className = CatalogueClassWriter.CreateClassName(v.Designation);
//                enums.AppendLine($"{_indt}{_indt}{className},");
//                utility.AppendLine($"{_indt}{_indt}{_indt}{_indt}{catalogue}.{className} => new {className}(),");
//            }

//            enums.AppendLine($"    }}\r\n}}");
//            utility.AppendLine($@"                _ => throw new System.NotImplementedException(),
//            }};
//        }}
//    }}
//}}");

//            path = Path.Combine(directory.FullName, "CatalogueProfiles", catalogue);
//            var file = new StreamWriter($"{path}/{catalogue}.cs");
//            file.Write(enums);
//            file.Close();
//            file = new StreamWriter($"{path}/Utility.cs");
//            file.Write(utility);
//            file.Close();
        }
    }
}
