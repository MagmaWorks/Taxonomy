using System.Text;

namespace CountryGenerator
{
    internal class ClassWriter
    {

        private static string _classType = "public sealed class";
        private static string _abstractClass = "SingletonCountryBase";
        private static string _interface = "ICountry";

        public static void WriteClass(CsvValues values, string filePath, string nameSpace)
        {
            string className = ToPascalCase(values.Name);
            var sb = new StringBuilder();
            sb.AppendLine(
$@"namespace {nameSpace}
{{
    {_classType} {className} : {_abstractClass}<{className}>, {_interface}
    {{
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = ""{values.Name}"";
        private const string _countryCode = ""{values.CountryCode}"";

        public {className}() {{ }}
    }}
}}
");
            var file = new StreamWriter($"{filePath}/{className}.cs");
            file.Write(sb);
            file.Close();
        }

        public static string ToPascalCase(string value)
        {
            value = value.Split(',')[0]
                .Replace("-", " ")
                .Replace("(", " ").Replace(")", " ")
                .Replace("'", string.Empty).Replace(".", string.Empty);

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
