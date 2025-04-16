using System.Text;
using System.Text.RegularExpressions;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;
using UnitsNet;
using UnitsNet.Units;

namespace ProfileTests.Catalogue
{
    public class AmericanTests
    {
        public Dictionary<string, List<string>> CsvValues
        {
            get
            {
                if (_csvValues == null)
                {
                    ReadCsvValues();
                }

                return _csvValues;
            }
        }

        private Dictionary<string, List<string>> _csvValues = null;

        public static IEnumerable<object[]> AmericanEnumValues()
        {
            foreach (American catalogueProfile in Enum.GetValues(typeof(American)))
            {
                yield return new object[] { catalogueProfile };
            }
        }

        [Theory]
        [MemberData(nameof(AmericanEnumValues))]
        public void TestAmericanCatalogue(American type)
        {
            ICatalogue profile = MagmaWorks.Taxonomy.Profiles.Utility.GetCatalogue(type);
            Assert.NotNull(profile);
            List<string> expectedValues = CsvValues[profile.Label];
            ProfileValuesTest(profile, expectedValues);
            IAmericanCatalogueTest(profile);
            ICatalogueTest(profile);

            SurvivesRoundtripDeserializationTest(profile, expectedValues);
            SurvivesRoundtripDeserializationTest((IAmericanCatalogue)profile, expectedValues);
            switch (profile)
            {
                case IIParallelFlange iParallelFlange:
                    SurvivesRoundtripDeserializationTest(iParallelFlange, expectedValues);
                    break;

                case IITaperFlange iTaperFlange:
                    SurvivesRoundtripDeserializationTest(iTaperFlange, expectedValues);
                    break;

                case IChannelTaperFlange cTaperFlange:
                    SurvivesRoundtripDeserializationTest(cTaperFlange, expectedValues);
                    break;

                case ILeg leg:
                    SurvivesRoundtripDeserializationTest(leg, expectedValues);
                    break;

                case ICutTeeParallelFlange tParallelFlange:
                    SurvivesRoundtripDeserializationTest(tParallelFlange, expectedValues);
                    break;

                case ICutTeeTaperFlange tTaperFlange:
                    SurvivesRoundtripDeserializationTest(tTaperFlange, expectedValues);
                    break;

                case IDoubleAngle doubleL:
                    SurvivesRoundtripDeserializationTest(doubleL, expectedValues);
                    break;

                case IRoundedRectangularHollow rhs:
                    SurvivesRoundtripDeserializationTest(rhs, expectedValues);
                    break;

                case ICircularHollow pipe:
                    SurvivesRoundtripDeserializationTest(pipe, expectedValues);
                    break;

                default:
                    Assert.Fail("Unknown shape type");
                    break;
            }
        }

        private void ProfileValuesTest(ICatalogue profile, List<string> expectedValues)
        {
            switch (profile)
            {
                case IIParallelFlange iParallelFlange:
                    IParallelFlangeProfileTest(iParallelFlange, expectedValues);
                    break;

                case IITaperFlange iTaperFlange:
                    ITaperFlangeProfileTest(iTaperFlange, expectedValues);
                    break;

                case IChannelTaperFlange cTaperFlange:
                    CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                case ILeg leg:
                    LegProfileTest(leg, expectedValues);
                    break;

                case ICutTeeParallelFlange tParallelFlange:
                    CutTParallelFlangeProfileTest(tParallelFlange, expectedValues);
                    break;

                case ICutTeeTaperFlange tTaperFlange:
                    CutTTaperFlangeProfileTest(tTaperFlange, expectedValues);
                    break;

                case IDoubleAngle doubleL:
                    B2BAngleFlangeProfileTest(doubleL, expectedValues);
                    break;

                case IRoundedRectangularHollow rhs:
                    RHSProfileTest(rhs, expectedValues);
                    break;

                case ICircularHollow pipe:
                    PipeProfileTest(pipe, expectedValues);
                    break;

                default:
                    Assert.Fail("Unknown shape type");
                    break;
            }
        }

        private void IParallelFlangeProfileTest(IIParallelFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[6]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[11]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[16]), prfl.WebThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[19]), prfl.FlangeThickness.Inches, 0.001);
            Length k1 = prfl.FilletRadius + prfl.WebThickness / 2;
            Assert.Equal(double.Parse(expectedValues[26]), k1.Inches, 0.001);
        }

        private void ITaperFlangeProfileTest(IITaperFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[6]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[11]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[16]), prfl.WebThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[19]), prfl.FlangeThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[81]), prfl.WebHeight.Inches, 0.001);
            Length filletRadius = (prfl.Height - 2 * prfl.FlangeThickness - prfl.WebHeight) / 2;
            Length toeRadius = filletRadius * 0.6;
            Assert.Equal(filletRadius.Inches, prfl.FilletRadius.Inches, 0.001);
            Assert.Equal(toeRadius.Inches, prfl.ToeRadius.Inches, 0.001);
        }

        private void CTaperFlangeProfileTest(IChannelTaperFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[6]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[11]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[16]), prfl.WebThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[19]), prfl.FlangeThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[81]), prfl.WebHeight.Inches, 0.001);
            Length filletRadius = (prfl.Height - 2 * prfl.FlangeThickness - prfl.WebHeight) / 2;
            Length toeRadius = filletRadius * 0.5;
            Assert.Equal(filletRadius.Inches, prfl.FilletRadius.Inches, 0.001);
            Assert.Equal(toeRadius.Inches, prfl.ToeRadius.Inches, 0.001);
        }

        private void LegProfileTest(ILeg prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[6]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[14]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[21]), prfl.WebThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[21]), prfl.FlangeThickness.Inches, 0.001);
            Length k = prfl.FlangeThickness - prfl.FilletRadius;
            Assert.Equal(double.Parse(expectedValues[24]), k.Inches, 0.001);
            Length toeRadius = prfl.FilletRadius * 0.5;
            Assert.Equal(toeRadius.Inches, prfl.ToeRadius.Inches, 0.001);
        }

        private void CutTParallelFlangeProfileTest(ICutTeeParallelFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[6]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[11]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[16]), prfl.WebThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[19]), prfl.FlangeThickness.Inches, 0.001);
            Length k = prfl.Height - prfl.FilletRadius;
            Assert.Equal(double.Parse(expectedValues[24]), k.Inches, 0.001);
        }

        private void CutTTaperFlangeProfileTest(ICutTeeTaperFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[6]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[11]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[16]), prfl.WebThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[19]), prfl.FlangeThickness.Inches, 0.001);
            Length k = prfl.Height - prfl.FilletRadius;
            Assert.Equal(double.Parse(expectedValues[24]), k.Inches, 0.001);
            Length toeRadius = prfl.FilletRadius * 0.5;
            Assert.Equal(toeRadius.Inches, prfl.ToeRadius.Inches, 0.001);
        }

        private void B2BAngleFlangeProfileTest(IDoubleAngle prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[6]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[14]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[21]), prfl.WebThickness.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[21]), prfl.FlangeThickness.Inches, 0.001);
            Utility.TestUtility.TestLengthsAreEqual(ExpectedB2BDistance(expectedValues[1]), prfl.BackToBackDistance);
        }

        private void RHSProfileTest(IRoundedRectangularHollow prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[8]), prfl.Height.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[13]), prfl.Width.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[9]), prfl.FlatHeight.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[14]), prfl.FlatWidth.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[22]), prfl.Thickness.Inches, 0.001);
        }

        private void PipeProfileTest(ICircularHollow prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal(double.Parse(expectedValues[10]), prfl.Diameter.Inches, 0.001);
            Assert.Equal(double.Parse(expectedValues[22]), prfl.Thickness.Inches, 0.001);
        }

        private Length ExpectedB2BDistance(string label)
        {
            int numberOfXInName = label.Count(x => x == 'X');
            if (numberOfXInName > 2)
            {
                string fraction = label.Split('X').Last()
                    .Replace("LLBB", string.Empty).Replace("SLBB", string.Empty);
                double preFractionNumber = 0;
                if (fraction.Contains('-'))
                {
                    preFractionNumber = double.Parse(fraction.Split('-').First());
                    fraction = fraction.Split('-').Last();
                }

                string[] fractionParts = fraction.Split('/');
                double distance = preFractionNumber + Math.Round(double.Parse(fractionParts[0]) / double.Parse(fractionParts[1]), 3);
                return new Length(distance, LengthUnit.Inch);
            }
            else
            {
                return new Length(0, LengthUnit.Inch);
            }
        }

        private void IAmericanCatalogueTest(ICatalogue profile)
        {
            var prfl = (IAmericanCatalogue)profile;
            string name = RemoveSpecialCharacters(prfl.Label);
            if (name.StartsWith("2L"))
            {
                name = "DoubleL";
            }
            else
            {
                name = RemoveDigits(name.Split(' ')[0].Replace("X", string.Empty));
                if (name.Length > 4)
                {
                    name = name.Substring(0, 4);
                }
            }

            // Assert
            Assert.Equal(name, Enum.GetName(prfl.Shape));
            Assert.Equal(prfl.Shape, prfl.Type);
        }

        private void ICatalogueTest(ICatalogue prfl)
        {
            // Assert
            Assert.Equal(MagmaWorks.Taxonomy.Profiles.Catalogue.AmericanAISC, prfl.Catalogue);
        }

        private void SurvivesRoundtripDeserializationTest<T>(T profile, List<string> expectedValues)
            where T : IProfile
        {
            // Act
            string json = profile.ToJson();
            T prfl = json.FromJson<T>();

            // Assert
            ProfileValuesTest((ICatalogue)prfl, expectedValues);
        }

        private void ReadCsvValues()
        {
            _csvValues = new Dictionary<string, List<string>>();
            string path = $"../../../aisc-shapes-database-v16.0.csv";
            DirectoryInfo directory = Directory.GetParent(path).Parent;
            path = Path.Combine(directory.FullName, "CatalogueGenerator", "aisc-shapes-database-v16.0.csv");
            List<string> csvLines = File.ReadAllLines(path).Skip(1).ToList();
            foreach (string csvLine in csvLines)
            {
                string[] values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                string key = values[1].Replace("\"", string.Empty);
                List<string> value = values.ToList();
                _csvValues.Add(key, value);
            }
        }

        private string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private string RemoveDigits(string str)
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
