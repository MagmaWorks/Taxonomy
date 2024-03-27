using System.Text;

namespace CountryGenerator
{
    internal class ClassWriter
    {
        private static string _namespace = "MagmaWorks.Taxonomy.Countries";
        private static string _classType = "public sealed class";
        private static string _abstractClass = "SingletonCountryBase";
        private static string _interface = "ICountry";
        private static string _indt = "    ";

        public static void WriteClass(CsvValues values, string filePath)
        {
            string className = ToPascalCase(values.Name);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"namespace {_namespace}");
            sb.AppendLine("{");
            sb.AppendLine($"{_indt}{_classType} {className} : {_abstractClass}<{className}>, {_interface}");
            sb.AppendLine($"{_indt}{{");
            sb.AppendLine($"{_indt}{_indt}public string Name => _name;");
            sb.AppendLine($"{_indt}{_indt}public string CountryCode => _countryCode;");
            sb.AppendLine();
            sb.AppendLine($"{_indt}{_indt}private const string _name = \"{values.Name}\";");
            sb.AppendLine($"{_indt}{_indt}private const string _countryCode = \"{values.CountryCode}\";");
            sb.AppendLine();
            sb.AppendLine($"{_indt}{_indt}public {className}() {{ }}");
            sb.AppendLine($"{_indt}}}");
            sb.AppendLine("}");
            sb.AppendLine();

            var file = new StreamWriter($"{filePath}/{className}.cs");
            file.Write(sb);
            file.Close();
        }

        private static string ToPascalCase(string value)
        {
            value = value.Split(',')[0]
                .Replace("-", " ")
                .Replace("(", " ").Replace(")", " ")
                .Replace("'", string.Empty);

            value = TrimSpaces(value);

            if (!value.Contains(' ') && !value.Contains('_'))
            {
                return value[0].ToString().ToUpper() + value.Substring(1).ToLower();
            }

            string returnValue = string.Empty;
            string[] splittedText = value.ToLower().Replace(' ', '_').Split('_');

            return splittedText.Aggregate(returnValue,
              (current, word) => current + word[0].ToString().ToUpper() + word.Substring(1));
        }

        private static string TrimSpaces(string value)
        {
            while (value.Contains("  "))
            {
                value = value.Replace("  ", " ");
            }

            return value.Trim();
        }
    }
}
