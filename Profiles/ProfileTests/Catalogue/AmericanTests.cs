using System.Text;
using System.Text.RegularExpressions;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using Newtonsoft.Json.Linq;
using OasysUnits;

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
                    //CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                case ICutTeeParallelFlange tParallelFlange:
                    //CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                case ICutTeeTaperFlange tTaperFlange:
                    //CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                case IAngle doubleL:
                    //CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                case IRoundedRectangularHollow rhs:
                    //CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                case ICircularHollow pipe:
                    //CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                default:
                    Assert.Fail("Unknown shape type");
                    break;
            }
        }

        private void IParallelFlangeProfileTest(IIParallelFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal($"{expectedValues[6]} in", prfl.Height.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[11]} in", prfl.Width.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[16]} in", prfl.WebThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[19]} in", prfl.FlangeThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[6]} in", prfl.FilletRadius.ToString().Replace(",", string.Empty));
            Length webStraightPart = prfl.Height - 2 * (prfl.FlangeThickness + prfl.FilletRadius);
            Assert.Equal($"{expectedValues[81]} in", webStraightPart.ToString().Replace(",", string.Empty));
        }

        private void ITaperFlangeProfileTest(IITaperFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal($"{expectedValues[6]} in", prfl.Height.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[11]} in", prfl.Width.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[16]} in", prfl.WebThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[19]} in", prfl.FlangeThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[81]} in", prfl.WebHeight.ToString().Replace(",", string.Empty));


            Assert.Equal($"{expectedValues[6]} in", prfl.FilletRadius.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[7]} in", prfl.ToeRadius.ToString().Replace(",", string.Empty));
        }

        private void CTaperFlangeProfileTest(IChannelTaperFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal($"{expectedValues[1]} in", prfl.Height.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[2]} in", prfl.Width.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[3]} in", prfl.WebThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[4]} in", prfl.FlangeThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[6]} in", prfl.FilletRadius.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[7]} in", prfl.ToeRadius.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[8]} in", prfl.WebHeight.ToString().Replace(",", string.Empty));
        }

        private void IAmericanCatalogueTest(ICatalogue profile)
        {
            var prfl = (IAmericanCatalogue)profile;
            string name = RemoveSpecialCharacters(prfl.Label);
            if (name.StartsWith("HE") || name.StartsWith("IPE"))
            {
                name = Regex.Replace(name, @"[\d-]", string.Empty)
                .Replace(" ", string.Empty);
            }
            else
            {
                name = RemoveDigits(name.Split(' ')[0]);
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
