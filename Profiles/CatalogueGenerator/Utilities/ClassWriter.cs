using System.Text;
using System.Text.RegularExpressions;
using MagmaWorks.Taxonomy.Profiles;

namespace CatalogueProfileGenerator
{
    internal class ClassWriter
    {
        public static void WriteEN10365Class(CsvValues values, string filePath, string nameSpace)
        {
            string className = CreateClassName(values.Designation);
            EuropeanShapeType shapeType = GetEuropeanShapeTypeName(values.Designation);
            string shapeName = Enum.GetName(typeof(EuropeanShapeType), shapeType);
            string interfaceName = GetEuropeanInterfaceName(shapeType);
            string classProperties = CreateProperties(shapeType, values);
            var sb = new StringBuilder();
            sb.AppendLine(
$@"using OasysUnits;
using OasysUnits.Units;

namespace {nameSpace}
{{
    public sealed class {className} : SingletonEuropeanBase<{className}>, {interfaceName}
    {{
        public override EuropeanShapeType ShapeType => EuropeanShapeType.{shapeName};
        public override string Designation => ""{values.Designation}"";
        {classProperties}

        public {className}() {{ }}
    }}
}}
");
            var file = new StreamWriter($"{filePath}/{className}.cs");
            file.Write(sb);
            file.Close();
        }

        public static string CreateClassName(string value)
        {
            value = value.Split(',')[0]
                .Replace("-", " ").Replace("(", " ").Replace(")", " ")
                .Replace("'", string.Empty).Replace(".", string.Empty)
                .Replace("_", string.Empty).Replace(",", "_")
                .Replace("×", "x");

            value = TrimSpaces(value);

            return value.Replace(" ", string.Empty);
        }

        private static string TrimSpaces(string value)
        {
            while (value.Contains("  "))
            {
                value = value.Replace("  ", " ");
            }

            return value.Trim();
        }

        private static string GetEuropeanTypeName(string name)
        {
            name = name.Replace("×", string.Empty).Replace("\"", string.Empty);
            if (name.StartsWith("HE") || name.StartsWith("IPE"))
            {
                return Regex.Replace(name, @"[\d-]", string.Empty)
                .Replace(" ", string.Empty);
            }

            return name.Split(' ')[0];
        }

        private static EuropeanShapeType GetEuropeanShapeTypeName(string name)
        {
            string typeName = GetEuropeanTypeName(name);
            return (EuropeanShapeType)Enum.Parse(typeof(EuropeanShapeType), typeName, true);
        }

        private static string GetEuropeanInterfaceName(EuropeanShapeType type)
        {
            switch (type)
            {
                case EuropeanShapeType.IPEAA:
                case EuropeanShapeType.IPEA:
                case EuropeanShapeType.IPE:
                case EuropeanShapeType.IPEO:
                case EuropeanShapeType.IPEV:
                case EuropeanShapeType.HEAA:
                case EuropeanShapeType.HEA:
                case EuropeanShapeType.HEB:
                case EuropeanShapeType.HEC:
                case EuropeanShapeType.HEM:
                case EuropeanShapeType.HE:
                case EuropeanShapeType.HL:
                case EuropeanShapeType.HD:
                case EuropeanShapeType.HP:
                case EuropeanShapeType.UBP:
                case EuropeanShapeType.UB:
                case EuropeanShapeType.UC:
                    return "IIParallelFlange";

                case EuropeanShapeType.IPN:
                case EuropeanShapeType.J:
                case EuropeanShapeType.HLZ:
                    return "IITaperFlange";

                case EuropeanShapeType.UPE:
                case EuropeanShapeType.PFC:
                    return "IChannelParallelFlange";

                case EuropeanShapeType.UPN:
                case EuropeanShapeType.U:
                case EuropeanShapeType.CH:
                    return "IChannelTaperFlange";

                default:
                    throw new NotImplementedException();
            }
        }

        private static string CreateProperties(Enum type, CsvValues values)
        {
            switch (type)
            {
                case EuropeanShapeType.IPEAA:
                case EuropeanShapeType.IPEA:
                case EuropeanShapeType.IPE:
                case EuropeanShapeType.IPEO:
                case EuropeanShapeType.IPEV:
                case EuropeanShapeType.HEAA:
                case EuropeanShapeType.HEA:
                case EuropeanShapeType.HEB:
                case EuropeanShapeType.HEC:
                case EuropeanShapeType.HEM:
                case EuropeanShapeType.HE:
                case EuropeanShapeType.HL:
                case EuropeanShapeType.HD:
                case EuropeanShapeType.HP:
                case EuropeanShapeType.UBP:
                case EuropeanShapeType.UB:
                case EuropeanShapeType.UC:
                case EuropeanShapeType.UPE:
                case EuropeanShapeType.PFC:
                    return $@"public Length Height => new Length({values.Values[1]}, LengthUnit.Millimeter);
        public Length Width => new Length({values.Values[2]}, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length({values.Values[4]}, LengthUnit.Millimeter);
        public Length WebThickness => new Length({values.Values[3]}, LengthUnit.Millimeter);
        public Length FilletRadius => new Length({values.Values[6]}, LengthUnit.Millimeter);";

                case EuropeanShapeType.IPN:
                case EuropeanShapeType.J:
                case EuropeanShapeType.HLZ:
                case EuropeanShapeType.UPN:
                case EuropeanShapeType.U:
                case EuropeanShapeType.CH:
                    return $@"public Length Height => new Length({values.Values[1]}, LengthUnit.Millimeter);
        public Length Width => new Length({values.Values[2]}, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length({values.Values[4]}, LengthUnit.Millimeter);
        public Length WebThickness => new Length({values.Values[3]}, LengthUnit.Millimeter);
        public Length FilletRadius => new Length({values.Values[6]}, LengthUnit.Millimeter);
        public Length ToeRadius => new Length({values.Values[7]}, LengthUnit.Millimeter);
        public Length WebHeight => new Length({values.Values[8]}, LengthUnit.Millimeter);";

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
