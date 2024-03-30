using System.Text;

namespace CatalogueGenerator.Utilities
{
    public struct CatalogueClassProperties
    {
        public List<string> Usings;
        public string NameSpace;
        public string AccessModifier;
        public string Name;
        public string Abstract;
        public string Interface;
        public List<ClassProperty> Properties;

        public CatalogueClassProperties(
            List<string> usings, string nmspc, string accessModifier, string name, string abstrct, string intrfc)
        {
            Usings = usings;
            NameSpace = nmspc;
            AccessModifier = accessModifier;
            Name = string.Empty;
            Abstract = abstrct;
            Interface = intrfc;
            Properties = new List<ClassProperty>();
            Name = SecureValidClassName(name);
        }

        public void AppendProperty(ClassProperty property)
        {
            Properties.Add(property);
        }

        public void AppendProperties(List<ClassProperty> property)
        {
            Properties.AddRange(property);
        }

        public void WriteClassToFile(string filePath)
        {
            var sb = new StringBuilder();
            if (Usings != null && Usings.Count != 0)
            {
                foreach (string us in Usings)
                {
                    sb.AppendLine($"using {us};");
                }

                sb.AppendLine();
            }

            var inheritance = new StringBuilder();
            if (Abstract != string.Empty || Interface != string.Empty)
            {
                inheritance.Append(" : ");
                if (Abstract != string.Empty)
                {
                    inheritance.Append($"{Abstract}<{Name}>");
                    if (Interface != string.Empty)
                    {
                        inheritance.Append(", ");
                    }
                }

                if (Interface != string.Empty)
                {
                    inheritance.Append(Interface);
                }
            }

            sb.AppendLine($@"namespace {NameSpace}
{{
    {AccessModifier} class {Name}{inheritance.ToString()}
    {{");
            foreach (ClassProperty prop in Properties)
            {
                sb.AppendProperty(prop);
            }

            sb.AppendLine($@"
        public {Name}() {{ }}
    }}
}}");
            var file = new StreamWriter($"{filePath}/{Name}.cs");
            file.Write(sb);
            file.Close();
        }

        private static string SecureValidClassName(string className)
        {
            if (className.StartsWith("2L"))
            {
                className = className.Replace("2L", "DoubleL");
            }

            string name = RemoveSpecialCharacters(className.Replace("×", "x").Replace("X", "x")
                .Replace(",", "_").Replace(".", "_").Replace("-", "_").Replace("/", "over"));
            return TrimSpaces(name);
        }

        private static string TrimSpaces(string value)
        {
            while (value.Contains("  "))
            {
                value = value.Replace("  ", " ");
            }

            return value.Trim();
        }

        private static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private static string RemoveDigits(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
