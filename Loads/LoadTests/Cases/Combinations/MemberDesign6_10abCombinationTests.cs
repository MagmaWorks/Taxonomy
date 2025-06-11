using LoadCaseTests;
using MagmaWorks.Taxonomy.Loads.Combinations;

namespace CombinationTests
{
    public class MemberDesign6_10abCombinationTests
    {
        public static IList<IMemberDesignCombination> Create()
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

            return ENCombinationFactory.CreateStrGeoSetB(loadCases);
        }

        [Fact]
        public void NameAndDefinitionTest()
        {
            // Assemble
            // Act
            IList<IMemberDesignCombination> combinations = Create();

            // Assert
            Assert.Equal("LC1: STR/GEO Set B, Eq. 6.10a - Leading Permanent combined with accompanying variable actions",
                combinations[0].Name);
            Assert.Equal("" + new Ratio(1.35, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.7, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·W + " + new Ratio(0.5, RatioUnit.DecimalFraction) + "·S + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·T)", combinations[0].Definition);

            Assert.Equal("LC2: STR/GEO Set B, Eq. 6.10b - Leading Live loads Category B",
                combinations[1].Name);
            Assert.Equal("" + new Ratio(1.35, RatioUnit.DecimalFraction) + "·" + new Ratio(0.85, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.6, RatioUnit.DecimalFraction) + "·W + " + new Ratio(0.5, RatioUnit.DecimalFraction) + "·S + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·T)", combinations[1].Definition);

            Assert.Equal("LC3: STR/GEO Set B, Eq. 6.10b - Leading Wind loads",
                combinations[2].Name);
            Assert.Equal("" + new Ratio(1.35, RatioUnit.DecimalFraction) + "·" + new Ratio(0.85, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·W + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.7, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.5, RatioUnit.DecimalFraction) + "·S + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·T)", combinations[2].Definition);

            Assert.Equal("LC4: STR/GEO Set B, Eq. 6.10b - Leading Wind loads with favourable permanent",
                combinations[3].Name);
            Assert.Equal("DL + SDL + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·W", combinations[3].Definition);

            Assert.Equal("LC5: STR/GEO Set B, Eq. 6.10b - Leading Snow loads",
                combinations[4].Name);
            Assert.Equal("" + new Ratio(1.35, RatioUnit.DecimalFraction) + "·" + new Ratio(0.85, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·S + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.7, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·W + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·T)", combinations[4].Definition);

            Assert.Equal("LC6: STR/GEO Set B, Eq. 6.10b - Leading Thermal loads",
                combinations[5].Name);
            Assert.Equal("" + new Ratio(1.35, RatioUnit.DecimalFraction) + "·" + new Ratio(0.85, RatioUnit.DecimalFraction) + "·(DL + SDL) + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·T + " + new Ratio(1.5, RatioUnit.DecimalFraction) + "·(" + new Ratio(0.7, RatioUnit.DecimalFraction) + "·Q + " + new Ratio(0.6, RatioUnit.DecimalFraction) + "·W + " + new Ratio(0.5, RatioUnit.DecimalFraction) + "·S)", combinations[5].Definition);
        }


        [Fact]
        public void CasesTest()
        {
            // Assemble
            // Act
            IList<IMemberDesignCombination> combinations = Create();

            // Assert
            Assert.Equal(6, combinations.Count);
            Assert.Equal(2, combinations[0].PermanentCases.Count);
            Assert.Empty(combinations[0].LeadingVariableCases);
            Assert.Empty(combinations[0].MainAccompanyingVariableCases);
            Assert.Equal(4, combinations[0].OtherAccompanyingVariableCases.Count);

            for (int i = 1; i < combinations.Count; i++)
            {
                Assert.Equal(2, combinations[i].PermanentCases.Count);
                Assert.Single(combinations[i].LeadingVariableCases);
                Assert.Empty(combinations[i].MainAccompanyingVariableCases);
                if (!combinations[i].LeadingVariableCases.First().IsHorizontal)
                {
                    Assert.Equal(3, combinations[i].OtherAccompanyingVariableCases.Count);
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

            IList<IMemberDesignCombination> combinations = Create();

            // Act
            IList<ILoad> lc1Loads = combinations[0].GetFactoredLoads();
            IList<ILoad> lc2Loads = combinations[1].GetFactoredLoads();
            IList<ILoad> lc3Loads = combinations[2].GetFactoredLoads();
            IList<ILoad> lc4Loads = combinations[3].GetFactoredLoads();
            IList<ILoad> lc5Loads = combinations[4].GetFactoredLoads();
            IList<ILoad> lc6Loads = combinations[5].GetFactoredLoads();

            // Assert
            // LC1: 1.35·(DL + SDL) + 1.5·(0.7·Q + 0.6·W + 0.5·S + 0.6·T)
            int i = 0;
            TestFactoredLoad(lc1Loads[i++], 1.35, dl);
            TestFactoredLoad(lc1Loads[i++], 1.35, sdl);
            TestFactoredLoad(lc1Loads[i++], 1.5 * 0.7, ll);
            TestFactoredLoad(lc1Loads[i++], 1.5 * 0.6, w);
            TestFactoredLoad(lc1Loads[i++], 1.5 * 0.5, s);
            TestFactoredLoad(lc1Loads[i++], 1.5 * 0.6, t);

            // LC2: 1.35·0.85·(DL + SDL) + 1.5·Q + 1.5·(0.6·W + 0.5·S + 0.6·T)
            i = 0;
            TestFactoredLoad(lc2Loads[i++], 1.35 * 0.85, dl);
            TestFactoredLoad(lc2Loads[i++], 1.35 * 0.85, sdl);
            TestFactoredLoad(lc2Loads[i++], 1.5, ll);
            TestFactoredLoad(lc2Loads[i++], 1.5 * 0.6, w);
            TestFactoredLoad(lc2Loads[i++], 1.5 * 0.5, s);
            TestFactoredLoad(lc2Loads[i++], 1.5 * 0.6, t);

            // LC3: 1.35·0.85·(DL + SDL) + 1.5·W + 1.5·(0.7·Q + 0.5·S + 0.6·T)
            i = 0;
            TestFactoredLoad(lc3Loads[i++], 1.35 * 0.85, dl);
            TestFactoredLoad(lc3Loads[i++], 1.35 * 0.85, sdl);
            TestFactoredLoad(lc3Loads[i++], 1.5, w);
            TestFactoredLoad(lc3Loads[i++], 1.5 * 0.7, ll);
            TestFactoredLoad(lc3Loads[i++], 1.5 * 0.5, s);
            TestFactoredLoad(lc3Loads[i++], 1.5 * 0.6, t);

            // LC4: 1.0·(DL + SDL) + 1.5·W
            i = 0;
            TestFactoredLoad(lc4Loads[i++], 1.0, dl);
            TestFactoredLoad(lc4Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc4Loads[i++], 1.5, w);

            // LC5: 1.35·0.85·(DL + SDL) + 1.5·S + 1.5·(0.7·Q + 0.6·W + 0.6·T)
            i = 0;
            TestFactoredLoad(lc5Loads[i++], 1.35 * 0.85, dl);
            TestFactoredLoad(lc5Loads[i++], 1.35 * 0.85, sdl);
            TestFactoredLoad(lc5Loads[i++], 1.5, s);
            TestFactoredLoad(lc5Loads[i++], 1.5 * 0.7, ll);
            TestFactoredLoad(lc5Loads[i++], 1.5 * 0.6, w);
            TestFactoredLoad(lc5Loads[i++], 1.5 * 0.6, t);

            // LC6: 1.35·0.85·(DL + SDL) + 1.5·T + 1.5·(0.7·Q + 0.6·W + 0.5·S)
            i = 0;
            TestFactoredLoad(lc6Loads[i++], 1.35 * 0.85, dl);
            TestFactoredLoad(lc6Loads[i++], 1.35 * 0.85, sdl);
            TestFactoredLoad(lc6Loads[i++], 1.5, t);
            TestFactoredLoad(lc6Loads[i++], 1.5 * 0.7, ll);
            TestFactoredLoad(lc6Loads[i++], 1.5 * 0.6, w);
            TestFactoredLoad(lc6Loads[i++], 1.5 * 0.5, s);
        }

        private void TestFactoredLoad(ILoad actual, double factor, ILoad expectedUnfactored)
        {
            Assert.Equivalent(
                expectedUnfactored.Factor(new Ratio(factor, RatioUnit.DecimalFraction)),
                actual);
        }
    }
}

