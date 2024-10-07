using LoadCaseTests;
using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Loads.Combinations;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace CombinationTests
{
    public class AccidentialCombinationTests
    {
        public static IList<IAccidentialCombination> Create(bool useFrequent)
        {
            IPermanentCase dl = PermanentCaseTests.CreateDLCase();
            IPermanentCase sdl = PermanentCaseTests.CreateSDLCase();
            IVariableCase ll = ImposedCaseTests.Create();
            IVariableCase w = WindCaseTests.Create();
            IVariableCase s = SnowCaseTests.Create(true);
            IVariableCase t = ThermalCaseTests.Create();
            IVariableCase impact = new VariableCase()
            {
                Name = "Truck impact",
                Nickname = "A",
                Loads = new List<ILoad>()
                {
                    new ColumnLoad(new Force(50, ForceUnit.Kilonewton))
                }
            };
            var otherCases = new List<ILoadCase>()
            {
                dl, sdl, ll, w, s, t
            };

            return ENCombinationFactory.CreateAccidential(
                impact, new Ratio(1.5, RatioUnit.DecimalFraction), otherCases,
                NationalAnnex.RecommendedValues, useFrequent);
        }

        [Fact]
        public void NameAndDefinitionWithFrequentTest()
        {
            // Assemble
            // Act
            IList<IAccidentialCombination> combinations = Create(true);

            // Assert
            Assert.Equal("LC1: Accidential, Eq. 6.11a/b - Leading Truck impact combined with Live loads Category B as main accompanying variable action",
                combinations[0].Name);
            Assert.Equal("DL + SDL + 1.5·A + 0.5·Q + 0.2·S", combinations[0].Definition);

            Assert.Equal("LC2: Accidential, Eq. 6.11a/b - Leading Truck impact combined with Wind loads as main accompanying variable action",
                combinations[1].Name);
            Assert.Equal("DL + SDL + 1.5·A + 0.2·W + 0.3·Q + 0.2·S", combinations[1].Definition);

            Assert.Equal("LC3: Accidential, Eq. 6.11a/b - Leading Truck impact combined with Snow loads as main accompanying variable action",
                combinations[2].Name);
            Assert.Equal("DL + SDL + 1.5·A + 0.5·S + 0.3·Q", combinations[2].Definition);

            Assert.Equal("LC4: Accidential, Eq. 6.11a/b - Leading Truck impact combined with Thermal loads as main accompanying variable action",
                combinations[3].Name);
            Assert.Equal("DL + SDL + 1.5·A + 0.5·T + 0.3·Q + 0.2·S", combinations[3].Definition);
        }

        [Fact]
        public void NameAndDefinitionWithQuasiTest()
        {
            // Assemble
            // Act
            IList<IAccidentialCombination> combinations = Create(false);

            // Assert
            Assert.Equal("LC1: Accidential, Eq. 6.11a/b - Leading Truck impact", combinations[0].Name);
            Assert.Equal("DL + SDL + 1.5·A + 0.3·Q + 0.2·S", combinations[0].Definition);
        }

        [Fact]
        public void CasesWithFrequentTest()
        {
            // Assemble
            IPermanentCase dl = PermanentCaseTests.CreateDLCase();
            IPermanentCase sdl = PermanentCaseTests.CreateSDLCase();
            IVariableCase ll = ImposedCaseTests.Create();
            IVariableCase w = WindCaseTests.Create();
            IVariableCase s = SnowCaseTests.Create(true);
            IVariableCase t = ThermalCaseTests.Create();
            IVariableCase impact = new VariableCase()
            {
                Name = "Truck impact",
                Nickname = "A",
                Loads = new List<ILoad>()
                {
                    new ColumnLoad(new Force(50, ForceUnit.Kilonewton))
                }
            };
            var otherCases = new List<ILoadCase>()
            {
                dl, sdl, ll, w, s, t
            };

            // Act
            IList<IAccidentialCombination> combinations = Create(true);

            // Assert
            Assert.Equal(4, combinations.Count);
            for (int i = 0; i < combinations.Count; i++)
            {
                Assert.Equal(2, combinations[i].PermanentCases.Count);
                Assert.Single(combinations[i].LeadingVariableCases);
                Assert.Equivalent(impact, combinations[i].LeadingVariableCases.FirstOrDefault());
                Assert.Single(combinations[i].MainAccompanyingVariableCases);
                Assert.DoesNotContain(otherCases[i + 2], combinations[i].OtherAccompanyingVariableCases);
                Assert.Equal(3, combinations[i].OtherAccompanyingVariableCases.Count);
                Assert.Equal(1.5, combinations[i].LeadingAccidentialPartialFactor.DecimalFractions);
            }
        }

        [Fact]
        public void CasesWithQuasiTest()
        {
            // Assemble
            IPermanentCase dl = PermanentCaseTests.CreateDLCase();
            IPermanentCase sdl = PermanentCaseTests.CreateSDLCase();
            IVariableCase ll = ImposedCaseTests.Create();
            IVariableCase w = WindCaseTests.Create();
            IVariableCase s = SnowCaseTests.Create(true);
            IVariableCase t = ThermalCaseTests.Create();
            IVariableCase impact = new VariableCase()
            {
                Name = "Truck impact",
                Nickname = "A",
                Loads = new List<ILoad>()
                {
                    new ColumnLoad(new Force(50, ForceUnit.Kilonewton))
                }
            };
            var otherCases = new List<ILoadCase>()
            {
                dl, sdl, ll, w, s, t
            };

            // Act
            IList<IAccidentialCombination> combinations = Create(false);

            // Assert
            Assert.Single(combinations);
            Assert.Equal(2, combinations[0].PermanentCases.Count);
            Assert.Single(combinations[0].LeadingVariableCases);
            Assert.Equivalent(impact, combinations[0].LeadingVariableCases.FirstOrDefault());
            Assert.Null(combinations[0].MainAccompanyingVariableCases);
            Assert.Equal(4, combinations[0].OtherAccompanyingVariableCases.Count);
            Assert.Equal(1.5, combinations[0].LeadingAccidentialPartialFactor.DecimalFractions);
        }

        [Fact]
        public void FactoredLoadsWithFrequentTest()
        {
            // Assemble
            ILoad dl = new Gravity();
            ILoad sdl = new AreaForce(new Pressure(2.5, PressureUnit.KilonewtonPerSquareMeter));
            ILoad ll = new AreaForce(new Pressure(5.0, PressureUnit.KilonewtonPerSquareMeter));
            ILoad w = new PointForce2d(new Force(90, ForceUnit.Kilonewton));
            ILoad s = new LineForce(new ForcePerLength(-15, ForcePerLengthUnit.KilonewtonPerMeter));
            ILoad t = new PointDisplacement(Length.Zero, Length.Zero, new Length(0.01, LengthUnit.Centimeter));
            ILoad impact = new ColumnLoad(new Force(50, ForceUnit.Kilonewton));

            IList<IAccidentialCombination> combinations = Create(true);

            // Act
            IList<ILoad> lc1Loads = combinations[0].GetFactoredLoads();
            IList<ILoad> lc2Loads = combinations[1].GetFactoredLoads();
            IList<ILoad> lc3Loads = combinations[2].GetFactoredLoads();
            IList<ILoad> lc4Loads = combinations[3].GetFactoredLoads();

            // Assert
            // LC1: DL + SDL + 1.5·A + 0.5·Q + 0.2·S
            int i = 0;
            TestFactoredLoad(lc1Loads[i++], 1.0, dl);
            TestFactoredLoad(lc1Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc1Loads[i++], 1.5, impact);
            TestFactoredLoad(lc1Loads[i++], 0.5, ll);
            TestFactoredLoad(lc1Loads[i++], 0.0, w);
            TestFactoredLoad(lc1Loads[i++], 0.2, s);
            TestFactoredLoad(lc1Loads[i++], 0.0, t);

            // LC2: DL + SDL + 1.5·A + 0.2·W + 0.3·Q + 0.2·S
            i = 0;
            TestFactoredLoad(lc2Loads[i++], 1.0, dl);
            TestFactoredLoad(lc2Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc2Loads[i++], 1.5, impact);
            TestFactoredLoad(lc2Loads[i++], 0.2, w);
            TestFactoredLoad(lc2Loads[i++], 0.3, ll);
            TestFactoredLoad(lc2Loads[i++], 0.2, s);
            TestFactoredLoad(lc2Loads[i++], 0.0, t);

            // LC3: DL + SDL + 1.5·A + 0.5·S + 0.3·Q
            i = 0;
            TestFactoredLoad(lc3Loads[i++], 1.0, dl);
            TestFactoredLoad(lc3Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc3Loads[i++], 1.5, impact);
            TestFactoredLoad(lc3Loads[i++], 0.5, s);
            TestFactoredLoad(lc3Loads[i++], 0.3, ll);
            TestFactoredLoad(lc3Loads[i++], 0.0, w);
            TestFactoredLoad(lc3Loads[i++], 0.0, t);

            // LC4: DL + SDL + 1.5·A + 0.5·T + 0.3·Q + 0.2·S
            i = 0;
            TestFactoredLoad(lc4Loads[i++], 1.0, dl);
            TestFactoredLoad(lc4Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc4Loads[i++], 1.5, impact);
            TestFactoredLoad(lc4Loads[i++], 0.5, t);
            TestFactoredLoad(lc4Loads[i++], 0.3, ll);
            TestFactoredLoad(lc4Loads[i++], 0.0, w);
            TestFactoredLoad(lc4Loads[i++], 0.2, s);
        }

        [Fact]
        public void FactoredLoadsWithQuasiTest()
        {
            // Assemble
            ILoad dl = new Gravity();
            ILoad sdl = new AreaForce(new Pressure(2.5, PressureUnit.KilonewtonPerSquareMeter));
            ILoad ll = new AreaForce(new Pressure(5.0, PressureUnit.KilonewtonPerSquareMeter));
            ILoad w = new PointForce2d(new Force(90, ForceUnit.Kilonewton));
            ILoad s = new LineForce(new ForcePerLength(-15, ForcePerLengthUnit.KilonewtonPerMeter));
            ILoad t = new PointDisplacement(Length.Zero, Length.Zero, new Length(0.01, LengthUnit.Centimeter));
            ILoad impact = new ColumnLoad(new Force(50, ForceUnit.Kilonewton));

            IList<IAccidentialCombination> combinations = Create(false);

            // Act
            IList<ILoad> lc1Loads = combinations[0].GetFactoredLoads();

            // Assert
            // LC1: DL + SDL + 1.5·A + 0.3·Q + 0.2·S
            int i = 0;
            TestFactoredLoad(lc1Loads[i++], 1.0, dl);
            TestFactoredLoad(lc1Loads[i++], 1.0, sdl);
            TestFactoredLoad(lc1Loads[i++], 1.5, impact);
            TestFactoredLoad(lc1Loads[i++], 0.3, ll);
            TestFactoredLoad(lc1Loads[i++], 0.0, w);
            TestFactoredLoad(lc1Loads[i++], 0.2, s);
            TestFactoredLoad(lc1Loads[i++], 0.0, t);
        }

        private void TestFactoredLoad(ILoad actual, double factor, ILoad expectedUnfactored)
        {
            Assert.Equivalent(
                expectedUnfactored.Factor(new Ratio(factor, RatioUnit.DecimalFraction)),
                actual);
        }
    }
}

