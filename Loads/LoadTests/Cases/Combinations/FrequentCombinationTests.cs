using LoadCaseTests;
using MagmaWorks.Taxonomy.Loads.Combinations;

namespace CombinationTests
{
    public class FrequentCombinationTests
    {
        public static IList<IFrequentCombination> Create()
        {
            IPermanentCase dl = PermanentCaseTests.CreateDLCase();
            IPermanentCase sdl = PermanentCaseTests.CreateSDLCase();
            IVariableCase ll = ImposedCaseTests.Create();
            IVariableCase w = WindCaseTests.Create();
            IVariableCase s = SnowCaseTests.Create(true);
            IVariableCase t = ThermalCaseTests.Create();

            var loadCases = new List<ILoadCase>()
            {
                dl, sdl, ll, w, s, t
            };

            return ENCombinationFactory.CreateFrequent(loadCases);
        }

        [Fact]
        public void NameAndDefinitionTest()
        {
            // Assemble
            // Act
            IList<IFrequentCombination> combinations = Create();

            // Assert
            Assert.Equal("LC1: SLS Frequent - Leading Live loads Category B",
                combinations[0].Name);
            Assert.Equal("DL + SDL + 0.5·Q + 0.2·S", combinations[0].Definition);

            Assert.Equal("LC2: SLS Frequent - Leading Wind loads",
                combinations[1].Name);
            Assert.Equal("DL + SDL + 0.2·W + 0.3·Q + 0.2·S", combinations[1].Definition);

            Assert.Equal("LC3: SLS Frequent - Leading Wind loads with unfavourable permanent",
                combinations[2].Name);
            Assert.Equal("DL + SDL + 0.2·W", combinations[2].Definition);

            Assert.Equal("LC4: SLS Frequent - Leading Snow loads",
                combinations[3].Name);
            Assert.Equal("DL + SDL + 0.5·S + 0.3·Q", combinations[3].Definition);

            Assert.Equal("LC5: SLS Frequent - Leading Thermal loads",
                combinations[4].Name);
            Assert.Equal("DL + SDL + 0.5·T + 0.3·Q + 0.2·S", combinations[4].Definition);
        }


        [Fact]
        public void CasesTest()
        {
            // Assemble
            // Act
            IList<IFrequentCombination> combinations = Create();

            // Assert
            Assert.Equal(5, combinations.Count);
            for (int i = 0; i < combinations.Count; i++)
            {
                Assert.Equal(2, combinations[i].PermanentCases.Count);
                Assert.Single(combinations[i].LeadingVariableCases);
                if (!combinations[i].LeadingVariableCases.First().IsHorizontal)
                {
                    Assert.Equal(3, combinations[i].AccompanyingVariableCases.Count);
                }
            }
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

            IList<IFrequentCombination> combinations = Create();

            // Act
            IList<ILoad> lc1Loads = combinations[0].GetFactoredLoads();
            IList<ILoad> lc2Loads = combinations[1].GetFactoredLoads();
            IList<ILoad> lc3Loads = combinations[2].GetFactoredLoads();
            IList<ILoad> lc4Loads = combinations[3].GetFactoredLoads();
            IList<ILoad> lc5Loads = combinations[4].GetFactoredLoads();

            // Assert
            // LC1: DL + SDL + 0.5·Q + 0.2·S
            int i = 0;
            TestFactoredLoad(lc1Loads[i++], 1.0, dl);
            TestFactoredLoad(lc1Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc1Loads[i++], 0.5, ll);
            TestFactoredLoad(lc1Loads[i++], 0.2, s);

            // LC2: DL + SDL + 0.2·W + 0.3·Q + 0.2·S
            i = 0;
            TestFactoredLoad(lc2Loads[i++], 1.0, dl);
            TestFactoredLoad(lc2Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc2Loads[i++], 0.2, w);
            TestFactoredLoad(lc2Loads[i++], 0.3, ll);
            TestFactoredLoad(lc2Loads[i++], 0.2, s);

            // LC3: DL + SDL + 0.2·W
            i = 0;
            TestFactoredLoad(lc3Loads[i++], 1.0, dl);
            TestFactoredLoad(lc3Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc3Loads[i++], 0.2, w);

            // LC4: DL + SDL + 0.5·S + 0.3·Q
            i = 0;
            TestFactoredLoad(lc4Loads[i++], 1.0, dl);
            TestFactoredLoad(lc4Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc4Loads[i++], 0.5, s);
            TestFactoredLoad(lc4Loads[i++], 0.3, ll);

            // LC5: DL + SDL + 0.5·T + 0.3·Q + 0.2·S
            i = 0;
            TestFactoredLoad(lc5Loads[i++], 1.0, dl);
            TestFactoredLoad(lc5Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc5Loads[i++], 0.5, t);
            TestFactoredLoad(lc5Loads[i++], 0.3, ll);
            TestFactoredLoad(lc5Loads[i++], 0.2, s);
        }

        private void TestFactoredLoad(ILoad actual, double factor, ILoad expectedUnfactored)
        {
            Assert.Equivalent(
                expectedUnfactored.Factor(new Ratio(factor, RatioUnit.DecimalFraction)),
                actual);
        }
    }
}

