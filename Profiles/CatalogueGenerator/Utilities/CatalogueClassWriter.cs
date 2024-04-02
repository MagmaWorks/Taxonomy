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

            Enum shape = null;
            string abstrct = string.Empty;
            string shapeEnumType = string.Empty;
            switch (values.Catalogue)
            {
                case Catalogue.European:
                    shape = GetEuropeanShapeName(values.Label);
                    abstrct = "SingletonEuropeanBase";
                    shapeEnumType = "EuropeanShape";
                    break;

                case Catalogue.American:
                    shape = GetAmericanShapeName(values.Type);
                    abstrct = "SingletonAmericanBase";
                    shapeEnumType = "AmericanShape";
                    break;
            }

            string interfaceName = GetInterfaceName(shape);

            var props = new List<ClassProperty>()
            {
                new ClassProperty("public override", shapeEnumType, "Shape", $"{shapeEnumType}.{shape}"),
                new ClassProperty("public override", "string", "Label", $"\"{values.Label}\"")
            };

            props.AddRange(CreateProperties(shape, values));

            if (values.Catalogue == Catalogue.American)
            {
                interfaceName = CatchAmericanAnormalities(interfaceName, shape, values.Values);
            }

            var clss = new CatalogueClassProperties(
                usngs, nameSpace, "public sealed", values.Label, abstrct, interfaceName);
            clss.AppendProperties(props);
            clss.WriteClassToFile(filePath);
            return clss.Name;
        }

        private static string CatchAmericanAnormalities(string interfaceName, Enum shape, List<string> values)
        {
            var usShape = (AmericanShape)shape;
            if (usShape == AmericanShape.M && values[3] == "T")
            {
                interfaceName = "IITaperFlange";
            }

            if (usShape == AmericanShape.MT && values[3] == "T")
            {
                interfaceName = "ICutTeeTaperFlange";
            }

            if (usShape == AmericanShape.HSS && !double.TryParse(values[8], out double _))
            {
                interfaceName = "ICircularHollow";
            }

            return interfaceName;
        }

        private static Enum GetEuropeanShapeName(string name)
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

            return (EuropeanShape)Enum.Parse(typeof(EuropeanShape), name, true);
        }

        private static Enum GetAmericanShapeName(string type)
        {
            if (type.Contains("2L"))
            {
                type = type.Replace("2L", "DoubleL");
            }

            return (AmericanShape)Enum.Parse(typeof(AmericanShape), type, true);
        }

        private static string GetInterfaceName(Enum type)
        {
            switch (type)
            {
                case EuropeanShape.IPEAA:
                case EuropeanShape.IPEA:
                case EuropeanShape.IPE:
                case EuropeanShape.IPEO:
                case EuropeanShape.IPEV:
                case EuropeanShape.HEAA:
                case EuropeanShape.HEA:
                case EuropeanShape.HEB:
                case EuropeanShape.HEC:
                case EuropeanShape.HEM:
                case EuropeanShape.HE:
                case EuropeanShape.HL:
                case EuropeanShape.HD:
                case EuropeanShape.HP:
                case EuropeanShape.UBP:
                case EuropeanShape.UB:
                case EuropeanShape.UC:

                case AmericanShape.W:
                case AmericanShape.M:
                case AmericanShape.HP:
                    return "IIParallelFlange";

                case EuropeanShape.IPN:
                case EuropeanShape.J:
                case EuropeanShape.HLZ:

                case AmericanShape.S:
                    return "IITaperFlange";

                case EuropeanShape.UPE:
                case EuropeanShape.PFC:
                    return "IChannelParallelFlange";

                case EuropeanShape.UPN:
                case EuropeanShape.U:
                case EuropeanShape.CH:

                case AmericanShape.C:
                case AmericanShape.MC:
                    return "IChannelTaperFlange";

                case AmericanShape.L:
                    return "ILeg";

                case AmericanShape.WT:
                case AmericanShape.MT:
                    return "ICutTeeParallelFlange";

                case AmericanShape.ST:
                    return "ICutTeeTaperFlange";

                case AmericanShape.DoubleL:
                    return "IAngle, IBackToBack";

                case AmericanShape.HSS:
                    return "IRoundedRectangularHollow";

                case AmericanShape.Pipe:
                    return "ICircularHollow";

                default:
                    throw new NotImplementedException();
            }
        }

        private static List<ClassProperty> CreateProperties(Enum type, CsvValues values)
        {
            var props = new List<ClassProperty>();

            double width;
            double height;
            double flangeThickness;
            double webThickness;
            double distanceFromEdgeFlangeToWebToe;
            double webStraightHeight;
            double filletRadius = 0;
            double toeRadius;

            switch (type)
            {
                case EuropeanShape.IPEAA:
                case EuropeanShape.IPEA:
                case EuropeanShape.IPE:
                case EuropeanShape.IPEO:
                case EuropeanShape.IPEV:
                case EuropeanShape.HEAA:
                case EuropeanShape.HEA:
                case EuropeanShape.HEB:
                case EuropeanShape.HEC:
                case EuropeanShape.HEM:
                case EuropeanShape.HE:
                case EuropeanShape.HL:
                case EuropeanShape.HD:
                case EuropeanShape.HP:
                case EuropeanShape.UBP:
                case EuropeanShape.UB:
                case EuropeanShape.UC:
                case EuropeanShape.UPE:
                case EuropeanShape.PFC:
                    props.Add(new ClassProperty("Height", values.Values[1], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("Width", values.Values[2], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[4], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("WebThickness", values.Values[3], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FilletRadius", values.Values[6], LengthUnit.Millimeter));
                    break;

                case EuropeanShape.IPN:
                case EuropeanShape.J:
                case EuropeanShape.HLZ:
                case EuropeanShape.UPN:
                case EuropeanShape.U:
                case EuropeanShape.CH:
                    props.Add(new ClassProperty("Height", values.Values[1], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("Width", values.Values[2], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[4], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("WebThickness", values.Values[3], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("FilletRadius", values.Values[6], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("ToeRadius", values.Values[7], LengthUnit.Millimeter));
                    props.Add(new ClassProperty("WebHeight", values.Values[8], LengthUnit.Millimeter));
                    break;

                case AmericanShape.W:
                case AmericanShape.M:
                case AmericanShape.HP:
                    props.Add(new ClassProperty("Height", values.Values[6], LengthUnit.Inch));
                    props.Add(new ClassProperty("Width", values.Values[11], LengthUnit.Inch));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[19], LengthUnit.Inch));
                    props.Add(new ClassProperty("WebThickness", values.Values[16], LengthUnit.Inch));
                    double k1 = double.Parse(values.Values[26]);
                    webThickness = double.Parse(values.Values[16]);
                    filletRadius = Math.Round(k1 - webThickness/2, 3);
                    props.Add(new ClassProperty("FilletRadius", filletRadius.ToString(), LengthUnit.Inch));
                    break;

                case AmericanShape.C:
                case AmericanShape.MC:
                    props.Add(new ClassProperty("Height", values.Values[6], LengthUnit.Inch));
                    props.Add(new ClassProperty("Width", values.Values[11], LengthUnit.Inch));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[19], LengthUnit.Inch));
                    props.Add(new ClassProperty("WebThickness", values.Values[16], LengthUnit.Inch));
                    height = double.Parse(values.Values[6]);
                    flangeThickness = double.Parse(values.Values[19]);
                    webStraightHeight = double.Parse(values.Values[81]);
                    filletRadius = Math.Round((height - 2 * flangeThickness - webStraightHeight) / 2, 3);
                    toeRadius = Math.Round(filletRadius * 0.5, 3);
                    props.Add(new ClassProperty("FilletRadius", filletRadius.ToString(), LengthUnit.Inch));
                    props.Add(new ClassProperty("ToeRadius", toeRadius.ToString(), LengthUnit.Inch));
                    props.Add(new ClassProperty("WebHeight", values.Values[81], LengthUnit.Inch));
                    break;

                case AmericanShape.S:
                    props.Add(new ClassProperty("Height", values.Values[6], LengthUnit.Inch));
                    props.Add(new ClassProperty("Width", values.Values[11], LengthUnit.Inch));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[19], LengthUnit.Inch));
                    props.Add(new ClassProperty("WebThickness", values.Values[16], LengthUnit.Inch));
                    height = double.Parse(values.Values[6]);
                    flangeThickness = double.Parse(values.Values[19]);
                    webStraightHeight = double.Parse(values.Values[81]);
                    filletRadius = Math.Round((height - 2 * flangeThickness - webStraightHeight) / 2, 3);
                    toeRadius = Math.Round(filletRadius * 0.6, 3);
                    props.Add(new ClassProperty("FilletRadius", filletRadius.ToString(), LengthUnit.Inch));
                    props.Add(new ClassProperty("ToeRadius", toeRadius.ToString(), LengthUnit.Inch));
                    props.Add(new ClassProperty("WebHeight", values.Values[81], LengthUnit.Inch));
                    break;

                case AmericanShape.L:
                    props.Add(new ClassProperty("Height", values.Values[6], LengthUnit.Inch));
                    props.Add(new ClassProperty("Width", values.Values[14], LengthUnit.Inch));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[21], LengthUnit.Inch));
                    props.Add(new ClassProperty("WebThickness", values.Values[21], LengthUnit.Inch));
                    width = double.Parse(values.Values[14]);
                    flangeThickness = double.Parse(values.Values[21]);
                    distanceFromEdgeFlangeToWebToe = double.Parse(values.Values[24]);
                    filletRadius = Math.Round(width - flangeThickness - distanceFromEdgeFlangeToWebToe, 3);
                    toeRadius = Math.Round(filletRadius * 0.5, 3);
                    props.Add(new ClassProperty("FilletRadius", filletRadius.ToString(), LengthUnit.Inch));
                    props.Add(new ClassProperty("ToeRadius", toeRadius.ToString(), LengthUnit.Inch));
                    break;

                case AmericanShape.DoubleL:
                    props.Add(new ClassProperty("Height", values.Values[6], LengthUnit.Inch));
                    props.Add(new ClassProperty("Width", values.Values[14], LengthUnit.Inch));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[21], LengthUnit.Inch));
                    props.Add(new ClassProperty("WebThickness", values.Values[21], LengthUnit.Inch));
                    int numberOfXInName = values.Label.Count(x => x == 'X');
                    if (numberOfXInName > 2)
                    {
                        string fraction = values.Label.Split('X').Last()
                            .Replace("LLBB", string.Empty).Replace("SLBB", string.Empty);
                        double preFractionNumber = 0;
                        if (fraction.Contains('-'))
                        {
                            preFractionNumber = double.Parse(fraction.Split('-').First());
                            fraction = fraction.Split('-').Last();
                        }

                        string[] fractionParts = fraction.Split('/');
                        double distance = preFractionNumber + Math.Round(double.Parse(fractionParts[0]) / double.Parse(fractionParts[1]), 3);
                        props.Add(new ClassProperty("BackToBackDistance", distance.ToString(), LengthUnit.Inch));
                    }
                    else
                    {
                        props.Add(new ClassProperty("BackToBackDistance", "0", LengthUnit.Inch));
                    }

                    break;

                case AmericanShape.WT:
                case AmericanShape.MT:
                    props.Add(new ClassProperty("Height", values.Values[6], LengthUnit.Inch));
                    props.Add(new ClassProperty("Width", values.Values[11], LengthUnit.Inch));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[19], LengthUnit.Inch));
                    props.Add(new ClassProperty("WebThickness", values.Values[16], LengthUnit.Inch));
                    width = double.Parse(values.Values[11]);
                    webThickness = double.Parse(values.Values[16]);
                    distanceFromEdgeFlangeToWebToe = double.Parse(values.Values[24]);
                    filletRadius = Math.Round((width - webThickness) / 2 - distanceFromEdgeFlangeToWebToe, 3);
                    props.Add(new ClassProperty("FilletRadius", filletRadius.ToString(), LengthUnit.Inch));
                    break;

                case AmericanShape.ST:
                    props.Add(new ClassProperty("Height", values.Values[6], LengthUnit.Inch));
                    props.Add(new ClassProperty("Width", values.Values[11], LengthUnit.Inch));
                    props.Add(new ClassProperty("FlangeThickness", values.Values[19], LengthUnit.Inch));
                    props.Add(new ClassProperty("WebThickness", values.Values[16], LengthUnit.Inch));
                    width = double.Parse(values.Values[11]);
                    webThickness = double.Parse(values.Values[16]);
                    distanceFromEdgeFlangeToWebToe = double.Parse(values.Values[24]);
                    filletRadius = Math.Round((width - webThickness) / 2 - distanceFromEdgeFlangeToWebToe, 3);
                    toeRadius = Math.Round(filletRadius * 0.5, 3);
                    props.Add(new ClassProperty("FilletRadius", filletRadius.ToString(), LengthUnit.Inch));
                    props.Add(new ClassProperty("ToeRadius", toeRadius.ToString(), LengthUnit.Inch));
                    break;

                case AmericanShape.HSS:
                    if (double.TryParse(values.Values[8], out double _))
                    {
                        props.Add(new ClassProperty("Height", values.Values[8], LengthUnit.Inch));
                        props.Add(new ClassProperty("Width", values.Values[13], LengthUnit.Inch));
                        props.Add(new ClassProperty("FlatHeight", values.Values[9], LengthUnit.Inch));
                        props.Add(new ClassProperty("FlatWidth", values.Values[14], LengthUnit.Inch));
                        props.Add(new ClassProperty("Thickness", values.Values[22], LengthUnit.Inch));
                    }
                    else
                    {
                        props.Add(new ClassProperty("Diameter", values.Values[10], LengthUnit.Inch));
                        props.Add(new ClassProperty("Thickness", values.Values[22], LengthUnit.Inch));
                    }

                    break;

                case AmericanShape.Pipe:
                    props.Add(new ClassProperty("Diameter", values.Values[10], LengthUnit.Inch));
                    props.Add(new ClassProperty("Thickness", values.Values[22], LengthUnit.Inch));
                    break;

                default:
                    throw new NotImplementedException();
            }

            var shape = (AmericanShape)type;
            if (shape == AmericanShape.M && values.Values[3] == "T")
            {
                toeRadius = Math.Round(filletRadius * 0.5, 3);
                props.Add(new ClassProperty("ToeRadius", toeRadius.ToString(), LengthUnit.Inch));
                props.Add(new ClassProperty("WebHeight", values.Values[81], LengthUnit.Inch));
            }

            if (shape == AmericanShape.MT && values.Values[3] == "T")
            {
                toeRadius = Math.Round(filletRadius * 0.5, 3);
                props.Add(new ClassProperty("ToeRadius", toeRadius.ToString(), LengthUnit.Inch));
            }

            return props;
        }
    }
}
