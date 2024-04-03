using System.Text;

namespace CatalogueGenerator.Utilities
{
    public struct UtilityClassProperties
    {
        public string NameSpace;
        public string AccessModifier = "public partial class Utility";
        public string Catalogue;
        public List<string> Values;

        public UtilityClassProperties(string nmspc, string catalogue)
        {
            NameSpace = nmspc;
            Catalogue = catalogue;
            Values = new List<string>();
        }

        public void AppendType(string name)
        {
            Values.Add(name);
        }

        public void WriteClassToFile(string filePath)
        {
            var sb = new StringBuilder();

            sb.AppendLine($@"namespace {NameSpace}
{{
    {AccessModifier}
    {{
        public static ICatalogue GetCatalogue({Catalogue} {Catalogue.ToLower()})
        {{
            return {Catalogue.ToLower()} switch
            {{");
            foreach (string v in Values)
            {
                sb.AppendLine($"                {Catalogue}.{v} => new {v}(),");
            }

            sb.AppendLine($@"                _ => throw new System.NotImplementedException(),
            }};
        }}
    }}
}}");
            var file = new StreamWriter($"{filePath}/{Catalogue}Utility.cs");
            file.Write(sb);
            file.Close();
        }
    }
}
