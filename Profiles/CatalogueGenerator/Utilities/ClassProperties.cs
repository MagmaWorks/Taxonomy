using System.Text;
using OasysUnits.Units;

namespace CatalogueGenerator.Utilities
{
    public struct ClassProperty
    {
        public string AccessModifier;
        public string Type;
        public string Name;
        public string Value;

        public ClassProperty(string accessModifier, string type, string name, string value)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Value = value;
        }

        public ClassProperty(string name, string lengthValue, LengthUnit unit)
        {
            AccessModifier = "public";
            Type = "Length";
            Name = name;
            Value = $"new Length({lengthValue}, LengthUnit.{unit})";
        }
    }

    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendProperty(this StringBuilder sb, ClassProperty prop)
        {
            string idt = "    ";
            sb.AppendLine(
                $@"{idt}{idt}{prop.AccessModifier} {prop.Type} {prop.Name} => {prop.Value};");
            return sb;
        }
    }
}
