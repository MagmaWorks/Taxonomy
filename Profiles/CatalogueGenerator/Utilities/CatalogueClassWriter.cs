using System.Text.RegularExpressions;
using CatalogueGenerator.Utilities;
using MagmaWorks.Taxonomy.Profiles;
using OasysUnits.Units;

namespace CatalogueProfileGenerator
{
    internal class CatalogueClassWriter
    {
        public static string GenerateClass(CsvValues values, string filePath, string nameSpace)
        {
            var usngs = new List<string>()
            {
                "OasysUnits",
                "OasysUnits.Units"
            };

            Enum shapeType = null;
            string abstrct = string.Empty;
            string shapeEnumType = string.Empty;
            if (values.Catalogue == Catalogue.European)
            {
                shapeType = GetEuropeanShapeTypeName(values.Designation);
                abstrct = "SingletonEuropeanBase";
                shapeEnumType = "EuropeanShapeType";
            }

            string interfaceName = GetInterfaceName(shapeType);

            var props = new List<ClassProperty>()
            {
                new ClassProperty("public override", shapeEnumType, "ShapeType", $"{shapeEnumType}.{shapeType}"),
                new ClassProperty("public override", "string", "Designation", $"\"{values.Designation}\"")
            };

            props.AddRange(CreateProperties(shapeType, values));

            var clss = new CatalogueClassProperties(
                usngs, nameSpace, "public sealed", values.Designation, abstrct, interfaceName);
            clss.AppendProperties(props);
            clss.WriteClassToFile(filePath);
            return clss.Name;
        }

        private static Enum GetEuropeanShapeTypeName(string name)
        {
            name = name.Replace("×", string.Empty).Replace("\"", string.Empty);
            if (name.StartsWith("HE") || name.StartsWith("IPE"))
            {
                name = Regex.Replace(name, @"[\d-]", string.Empty)
                .Replace(" ", string.Empty);
            }
            else
            {
                name = name.Split(' ')[0];
            }

            return (EuropeanShapeType)Enum.Parse(typeof(EuropeanShapeType), name, true);
        }

        private static string GetInterfaceName(Enum type)
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

        private static List<ClassProperty> CreateProperties(Enum type, CsvValues values)
        {
            var props = new List<ClassProperty>();
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
                    props.Add(new ClassProperty("Height", values.Values[1], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("Width", values.Values[2], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[4], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("WebThickness", values.Values[3], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FilletRadius", values.Values[6], LengthUnit.Millimeter));
                    break;

                case EuropeanShapeType.IPN:
                case EuropeanShapeType.J:
                case EuropeanShapeType.HLZ:
                case EuropeanShapeType.UPN:
                case EuropeanShapeType.U:
                case EuropeanShapeType.CH:
                    props.Add(new ClassProperty("Height", values.Values[1], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("Width", values.Values[2], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[4], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("WebThickness", values.Values[3], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FilletRadius", values.Values[6], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("ToeRadius", values.Values[7], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("WebHeight", values.Values[8], LengthUnit.Millimeter));
                    break;

                default:
                    throw new NotImplementedException();
            }

            return props;
        }
    }
}
