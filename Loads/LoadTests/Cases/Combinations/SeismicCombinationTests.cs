using LoadCaseTests;
using MagmaWorks.Taxonomy.Loads.Combinations;

namespace CombinationTests
{
    public class SeismicCombinationTests
    {
        public static IList<ISeismicCombination> Create()
        {
            IPermanentCase dl = PermanentCaseTests.CreateDLCase();
            IPermanentCase sdl = PermanentCaseTests.CreateSDLCase();
            IVariableCase ll = ImposedCaseTests.Create();
            IVariableCase w = WindCaseTests.Create();
            IVariableCase s = SnowCaseTests.Create(true);
            IVariableCase t = ThermalCaseTests.Create();
            IVariableCase seismic = new VariableCase()
            {
                Name = "Seismic Equivalent Horizontal Load in X-direction",
                Nickname = "EHL X",
                Loads = new List<ILoad>()
                {
                    new ColumnLoad(new Force(50, ForceUnit.Kilonewton))
                }
            };
            var otherCases = new List<ILoadCase>()
            {
                dl, sdl, ll, w, s, t
            };

            return ENCombinationFactory.CreateSeismic(new List<IVariableCase>() { seismic },
                new Ratio(1.5, RatioUnit.DecimalFraction), otherCases, NationalAnnex.RecommendedValues,
                "ULS", 54);
        }

        [Fact]
        public void NameAndDefinitionTest()
        {
            // Assemble
            // Act
            IList<ISeismicCombination> combinations = Create();

            // Assert
            Assert.Equal("ULS54: Seismic, Eq. 6.12a/b - Leading Seismic Equivalent Horizontal Load in X-direction",
                combinations[0].Name);
            Assert.Equal("DL + SDL + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·'EHL X' + " + new Ratio(0.3, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.2, RatioUnit.DecimalFraction) + "·S", combinations[0].Definition);
        }


        [Fact]
        public void CasesTest()
        {
            // Assemble
            IVariableCase seismic = new VariableCase()
            {
                Name = "Seismic Equivalent Horizontal Load in X-direction",
                Nickname = "EHL X",
                Loads = new List<ILoad>()
                {
                    new ColumnLoad(new Force(50, ForceUnit.Kilonewton))
                }
            };

            // Act
            IList<ISeismicCombination> combinations = Create();

            // Assert
            Assert.Single(combinations);
            Assert.Equal(2, combinations[0].PermanentCases.Count);
            Assert.Single(combinations[0].LeadingVariableCases);
            Assert.Equivalent(seismic, combinations[0].LeadingVariableCases.FirstOrDefault());
            Assert.Equal(4, combinations[0].AccompanyingVariableCases.Count);
            Assert.Equal(1.5, combinations[0].DesignSitation.LeadingActionPartialFactor);
        }

        [Fact]
        public void FactoredLoadsTest()
        {
            // Assemble
            ILoad dl = new Gravity();
            ILoad sdl = new AreaForce(new Pressure(2.5, PressureUnit.KilonewtonPerSquareMeter));
            ILoad ll = new AreaForce(new Pressure(5.0, PressureUnit.KilonewtonPerSquareMeter));
            ILoad w = new PointForce2d(new Force(90, ForceUnit.Kilonewton));
            ILoad s = new LineForce(new ForcePerLength(-15, ForcePerLengthUnit.KilonewtonPerMeter));
            ILoad t = new PointDisplacement(Length.Zero, Length.Zero, new Length(0.01, LengthUnit.Centimeter));
            ILoad impact = new ColumnLoad(new Force(50, ForceUnit.Kilonewton));

            IList<ISeismicCombination> combinations = Create();

            // Act
            IList<ILoad> lc1Loads = combinations[0].GetFactoredLoads();

            // Assert
            // LC1: DL + SDL + 1.5·A + 0.3·Q + 0.2·S
            int i = 0;
            TestFactoredLoad(lc1Loads[i++], 1.0, dl);
            TestFactoredLoad(lc1Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc1Loads[i++], 1.5, impact);
            TestFactoredLoad(lc1Loads[i++], 0.3, ll);
            TestFactoredLoad(lc1Loads[i++], 0.2, s);
        }

        private void TestFactoredLoad(ILoad actual, double factor, ILoad expectedUnfactored)
        {
            Assert.Equivalent(
                expectedUnfactored.Factor(new Ratio(factor, RatioUnit.DecimalFraction)),
                actual);
        }
    }
}

