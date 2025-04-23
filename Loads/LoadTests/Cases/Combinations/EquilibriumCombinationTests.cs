using LoadCaseTests;
using MagmaWorks.Taxonomy.Loads.Combinations;

namespace CombinationTests
{
    public class EquilibriumCombinationTests
    {
        public static IList<IEquilibriumCombination> Create()
        {
            IPermanentCase dl = PermanentCaseTests.CreateDLCase();
            IPermanentCase sdl = PermanentCaseTests.CreateSDLCase();
            IVariableCase ll = ImposedCaseTests.Create();
            IVariableCase w = WindCaseTests.Create();
            IVariableCase s = SnowCaseTests.Create(false);
            IVariableCase t = ThermalCaseTests.Create();

            var loadCases = new List<ILoadCase>()
            {
                dl, sdl, ll, w, s, t
            };

            return ENCombinationFactory.CreateEquSetA(loadCases);
        }

        [Fact]
        public void NameAndDefinitionTest()
        {
            // Assemble
            // Act
            IList<IEquilibriumCombination> combinations = Create();

            // Assert
            Assert.Equal("LC1: EQU Set A, Eq. 6.10 - Leading Live loads Category B",
                combinations[0].Name);
            Assert.Equal("" + new Ratio(1.1, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.6, RatioUnit.DecimalFraction) + "·W + " + new Ratio(0.5, RatioUnit.DecimalFraction) + "·S + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·T)", combinations[0].Definition);

            Assert.Equal("LC2: EQU Set A, Eq. 6.10 - Leading Wind loads",
                combinations[1].Name);
            Assert.Equal("" + new Ratio(1.1, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·W + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.7, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.5, RatioUnit.DecimalFraction) + "·S + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·T)", combinations[1].Definition);

            Assert.Equal("LC3: EQU Set A, Eq. 6.10 - Leading Wind loads with unfavourable permanent",
                combinations[2].Name);
            Assert.Equal("" + new Ratio(0.9, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·W", combinations[2].Definition);

            Assert.Equal("LC4: EQU Set A, Eq. 6.10 - Leading Snow loads",
                combinations[3].Name);
            Assert.Equal("" + new Ratio(1.1, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·S + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.7, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·W + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·T)", combinations[3].Definition);

            Assert.Equal("LC5: EQU Set A, Eq. 6.10 - Leading Thermal loads",
                combinations[4].Name);
            Assert.Equal("" + new Ratio(1.1, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·T + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.7, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·W + " + new Ratio(0.5, RatioUnit.DecimalFraction) + "·S)", combinations[4].Definition);
        }


        [Fact]
        public void CasesTest()
        {
            // Assemble
            // Act
            IList<IEquilibriumCombination> combinations = Create();

            // Assert
            Assert.Equal(5, combinations.Count);
            for (int i = 0; i < combinations.Count; i++)
            {
                Assert.Equal(2, combinations[i].PermanentCases.Count);
                Assert.Single(combinations[i].LeadingVariableCases);
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

            IList<IEquilibriumCombination> combinations = Create();

            // Act
            IList<ILoad> lc1Loads = combinations[0].GetFactoredLoads();
            IList<ILoad> lc2Loads = combinations[1].GetFactoredLoads();
            IList<ILoad> lc3Loads = combinations[2].GetFactoredLoads();
            IList<ILoad> lc4Loads = combinations[3].GetFactoredLoads();
            IList<ILoad> lc5Loads = combinations[4].GetFactoredLoads();

            // Assert
            // LC1:1.1·(DL + SDL) + 1.5·Q + 1.5·(0.6·W + 0.5·S + 0.6·T)
            int i = 0;
            TestFactoredLoad(lc1Loads[i++], 1.1, dl);
            TestFactoredLoad(lc1Loads[i++], 1.1, sdl);
            TestFactoredLoad(lc1Loads[i++], 1.5, ll);
            TestFactoredLoad(lc1Loads[i++], 1.5 * 0.6, w);
            TestFactoredLoad(lc1Loads[i++], 1.5 * 0.5, s);
            TestFactoredLoad(lc1Loads[i++], 1.5 * 0.6, t);

            // LC2: 1.1·(DL + SDL) + 1.5·W + 1.5·(0.7·Q + 0.5·S + 0.6·T)
            i = 0;
            TestFactoredLoad(lc2Loads[i++], 1.1, dl);
            TestFactoredLoad(lc2Loads[i++], 1.1, sdl);
            TestFactoredLoad(lc2Loads[i++], 1.5, w);
            TestFactoredLoad(lc2Loads[i++], 1.5 * 0.7, ll);
            TestFactoredLoad(lc2Loads[i++], 1.5 * 0.5, s);
            TestFactoredLoad(lc2Loads[i++], 1.5 * 0.6, t);

            // LC3: 0.9·(DL + SDL) + 1.5·W
            i = 0;
            TestFactoredLoad(lc3Loads[i++], 0.9, dl);
            TestFactoredLoad(lc3Loads[i++], 0.9, sdl);
            TestFactoredLoad(lc3Loads[i++], 1.5, w);

            // LC4: 1.1·(DL + SDL) + 1.5·S + 1.5·(0.7·Q + 0.6·W + 0.6·T)
            i = 0;
            TestFactoredLoad(lc4Loads[i++], 1.1, dl);
            TestFactoredLoad(lc4Loads[i++], 1.1, sdl);
            TestFactoredLoad(lc4Loads[i++], 1.5, s);
            TestFactoredLoad(lc4Loads[i++], 1.5 * 0.7, ll);
            TestFactoredLoad(lc4Loads[i++], 1.5 * 0.6, w);
            TestFactoredLoad(lc4Loads[i++], 1.5 * 0.6, t);

            // LC5: 1.1·(DL + SDL) + 1.5·T + 1.5·(0.7·Q + 0.6·W + 0.5·S)
            i = 0;
            TestFactoredLoad(lc5Loads[i++], 1.1, dl);
            TestFactoredLoad(lc5Loads[i++], 1.1, sdl);
            TestFactoredLoad(lc5Loads[i++], 1.5, t);
            TestFactoredLoad(lc5Loads[i++], 1.5 * 0.7, ll);
            TestFactoredLoad(lc5Loads[i++], 1.5 * 0.6, w);
            TestFactoredLoad(lc5Loads[i++], 1.5 * 0.5, s);
        }

        private void TestFactoredLoad(ILoad actual, double factor, ILoad expectedUnfactored)
        {
            Assert.Equivalent(
                expectedUnfactored.Factor(new Ratio(factor, RatioUnit.DecimalFraction)),
                actual);
        }
    }
}

