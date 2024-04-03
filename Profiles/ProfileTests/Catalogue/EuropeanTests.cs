using System.Text;
using System.Text.RegularExpressions;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;

namespace ProfileTests.Catalogue
{
    public class EuropeanTests
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

        public static IEnumerable<object[]> EuropeanEnumValues()
        {
            foreach (European catalogueProfile in Enum.GetValues(typeof(European)))
            {
                yield return new object[] { catalogueProfile };
            }
        }

        [Theory]
        [MemberData(nameof(EuropeanEnumValues))]
        public void TestEuropeanCatalogue(European type)
        {
            ICatalogue profile = MagmaWorks.Taxonomy.Profiles.Utility.GetCatalogue(type);
            Assert.NotNull(profile);
            List<string> expectedValues = CsvValues[profile.Label];
            ProfileValuesTest(profile, expectedValues);
            IEuropeanCatalogueTest(profile);
            ICatalogueTest(profile);

            SurvivesRoundtripDeserializationTest(profile, expectedValues);
            SurvivesRoundtripDeserializationTest((IEuropeanCatalogue)profile, expectedValues);
            switch (profile)
            {
                case IIParallelFlange iParallelFlange:
                    SurvivesRoundtripDeserializationTest(iParallelFlange, expectedValues);
                    break;

                case IChannelParallelFlange cParallelFlange:
                    SurvivesRoundtripDeserializationTest(cParallelFlange, expectedValues);
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

                case IChannelParallelFlange cParallelFlange:
                    CParallelFlangeProfileTest(cParallelFlange, expectedValues);
                    break;

                case IITaperFlange iTaperFlange:
                    ITaperFlangeProfileTest(iTaperFlange, expectedValues);
                    break;

                case IChannelTaperFlange cTaperFlange:
                    CTaperFlangeProfileTest(cTaperFlange, expectedValues);
                    break;

                default:
                    Assert.Fail("Unknown shape type");
                    break;
            }
        }

        private void IParallelFlangeProfileTest(IIParallelFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal($"{expectedValues[1]} mm", prfl.Height.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[2]} mm", prfl.Width.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[3]} mm", prfl.WebThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[4]} mm", prfl.FlangeThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[6]} mm", prfl.FilletRadius.ToString().Replace(",", string.Empty));
        }

        private void CParallelFlangeProfileTest(IChannelParallelFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal($"{expectedValues[1]} mm", prfl.Height.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[2]} mm", prfl.Width.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[3]} mm", prfl.WebThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[4]} mm", prfl.FlangeThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[6]} mm", prfl.FilletRadius.ToString().Replace(",", string.Empty));
        }

        private void ITaperFlangeProfileTest(IITaperFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal($"{expectedValues[1]} mm", prfl.Height.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[2]} mm", prfl.Width.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[3]} mm", prfl.WebThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[4]} mm", prfl.FlangeThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[6]} mm", prfl.FilletRadius.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[7]} mm", prfl.ToeRadius.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[8]} mm", prfl.WebHeight.ToString().Replace(",", string.Empty));
        }

        private void CTaperFlangeProfileTest(IChannelTaperFlange prfl, List<string> expectedValues)
        {
            // Assert
            Assert.Equal($"{expectedValues[1]} mm", prfl.Height.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[2]} mm", prfl.Width.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[3]} mm", prfl.WebThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[4]} mm", prfl.FlangeThickness.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[6]} mm", prfl.FilletRadius.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[7]} mm", prfl.ToeRadius.ToString().Replace(",", string.Empty));
            Assert.Equal($"{expectedValues[8]} mm", prfl.WebHeight.ToString().Replace(",", string.Empty));
        }

        private void IEuropeanCatalogueTest(ICatalogue profile)
        {
            var prfl = (IEuropeanCatalogue)profile;
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
            Assert.Equal(MagmaWorks.Taxonomy.Profiles.Catalogue.EuropeanEN10365, prfl.Catalogue);
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
            string path = $"../../../EN10365-2017.csv";
            DirectoryInfo directory = Directory.GetParent(path).Parent;
            path = Path.Combine(directory.FullName, "CatalogueGenerator", "EN10365-2017.csv");
            List<string> csvLines = File.ReadAllLines(path).Skip(1).ToList();
            foreach (string csvLine in csvLines)
            {
                string[] values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                string key = values[0].Replace("\"", string.Empty);
                List<string> value = values.Skip(1).ToList();
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
