using System.Text;

namespace CatalogueGenerator.Utilities
{
    public struct EnumClassProperties
    {
        public string NameSpace;
        public string AccessModifier = "public enum";
        public string Name;
        public List<string> Values;

        public EnumClassProperties(string nmspc, string name)
        {
            NameSpace = nmspc;
            Name = name;
            Values = new List<string>();
        }

        public void AppendEnum(string name)
        {
            Values.Add(name);
        }

        public void WriteClassToFile(string filePath)
        {
            var sb = new StringBuilder();

            sb.AppendLine($@"namespace {NameSpace}
{{
    {AccessModifier} {Name}
    {{");
            foreach (string v in Values)
            {
                sb.AppendLine($"        {v},");
            }
            sb.AppendLine($@"    }}
}}");
            var file = new StreamWriter($"{filePath}/{Name}.cs");
            file.Write(sb);
            file.Close();
        }
    }
}
