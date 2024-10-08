using LoadCaseTests;
using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Loads.Combinations;
using OasysUnits;
using OasysUnits.Units;

namespace CombinationTests
{
    public class CharacteristicCombinationTests
    {
        public static IList<ICharacteristicCombination> Create()
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

            return ENCombinationFactory.CreateCharacteristic(loadCases);
        }

        [Fact]
        public void NameAndDefinitionTest()
        {
            // Assemble
            // Act
            IList<ICharacteristicCombination> combinations = Create();

            // Assert
            Assert.Equal("LC1: SLS Characteristic - Leading Live loads Category B",
                combinations[0].Name);
            Assert.Equal("DL + SDL + Q + 0.6·W + 0.5·S + 0.6·T", combinations[0].Definition);

            Assert.Equal("LC2: SLS Characteristic - Leading Wind loads",
                combinations[1].Name);
            Assert.Equal("DL + SDL + W + 0.7·Q + 0.5·S + 0.6·T", combinations[1].Definition);

            Assert.Equal("LC3: SLS Characteristic - Leading Wind loads with unfavourable permanent",
                combinations[2].Name);
            Assert.Equal("DL + SDL + W", combinations[2].Definition);

            Assert.Equal("LC4: SLS Characteristic - Leading Snow loads",
                combinations[3].Name);
            Assert.Equal("DL + SDL + S + 0.7·Q + 0.6·W + 0.6·T", combinations[3].Definition);

            Assert.Equal("LC5: SLS Characteristic - Leading Thermal loads",
                combinations[4].Name);
            Assert.Equal("DL + SDL + T + 0.7·Q + 0.6·W + 0.5·S", combinations[4].Definition);
        }


        [Fact]
        public void CasesTest()
        {
            // Assemble
            // Act
            IList<ICharacteristicCombination> combinations = Create();

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

            IList<ICharacteristicCombination> combinations = Create();

            // Act
            IList<ILoad> lc1Loads = combinations[0].GetFactoredLoads();
            IList<ILoad> lc2Loads = combinations[1].GetFactoredLoads();
            IList<ILoad> lc3Loads = combinations[2].GetFactoredLoads();
            IList<ILoad> lc4Loads = combinations[3].GetFactoredLoads();
            IList<ILoad> lc5Loads = combinations[4].GetFactoredLoads();

            // Assert
            // LC1: DL + SDL + Q + 0.6·W + 0.5·S + 0.6·T
            int i = 0;
            TestFactoredLoad(lc1Loads[i++], 1.0, dl);
            TestFactoredLoad(lc1Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc1Loads[i++], 1.0, ll);
            TestFactoredLoad(lc1Loads[i++], 0.6, w);
            TestFactoredLoad(lc1Loads[i++], 0.5, s);
            TestFactoredLoad(lc1Loads[i++], 0.6, t);

            // LC2: DL + SDL + W + 0.7·Q + 0.5·S + 0.6·T
            i = 0;
            TestFactoredLoad(lc2Loads[i++], 1.0, dl);
            TestFactoredLoad(lc2Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc2Loads[i++], 1.0, w);
            TestFactoredLoad(lc2Loads[i++], 0.7, ll);
            TestFactoredLoad(lc2Loads[i++], 0.5, s);
            TestFactoredLoad(lc2Loads[i++], 0.6, t);

            // LC3: DL + SDL + W
            i = 0;
            TestFactoredLoad(lc3Loads[i++], 1.0, dl);
            TestFactoredLoad(lc3Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc3Loads[i++], 1.0, w);

            // LC4: DL + SDL + S + 0.7·Q + 0.6·W + 0.6·T
            i = 0;
            TestFactoredLoad(lc4Loads[i++], 1.0, dl);
            TestFactoredLoad(lc4Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc4Loads[i++], 1.0, s);
            TestFactoredLoad(lc4Loads[i++], 0.7, ll);
            TestFactoredLoad(lc4Loads[i++], 0.6, w);
            TestFactoredLoad(lc4Loads[i++], 0.6, t);

            // LC5: DL + SDL + T + 0.7·Q + 0.6·W + 0.5·S
            i = 0;
            TestFactoredLoad(lc5Loads[i++], 1.0, dl);
            TestFactoredLoad(lc5Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc5Loads[i++], 1.0, t);
            TestFactoredLoad(lc5Loads[i++], 0.7, ll);
            TestFactoredLoad(lc5Loads[i++], 0.6, w);
            TestFactoredLoad(lc5Loads[i++], 0.5, s);
        }

        private void TestFactoredLoad(ILoad actual, double factor, ILoad expectedUnfactored)
        {
            Assert.Equivalent(
                expectedUnfactored.Factor(new Ratio(factor, RatioUnit.DecimalFraction)),
                actual);
        }
    }
}

