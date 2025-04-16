using LoadCaseTests;
using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Loads.Combinations;
using UnitsNet;
using UnitsNet.Units;

namespace CombinationTests
{
    public class QuasiPermanentCombinationTests
    {
        public static IList<IQuasiPermanentCombination> Create()
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

            return ENCombinationFactory.CreateQuasiPermanent(loadCases);
        }

        [Fact]
        public void NameAndDefinitionTest()
        {
            // Assemble
            // Act
            IList<IQuasiPermanentCombination> combinations = Create();

            // Assert
            Assert.Equal("LC1: SLS Quasi-permanent",
                combinations[0].Name);
            Assert.Equal("DL + SDL + 0.3·Q + 0.2·S", combinations[0].Definition);
        }


        [Fact]
        public void CasesTest()
        {
            // Assemble
            // Act
            IList<IQuasiPermanentCombination> combinations = Create();

            // Assert
            Assert.Single(combinations);
            Assert.Equal(2, combinations[0].PermanentCases.Count);
            Assert.Empty(combinations[0].LeadingVariableCases);
            Assert.Equal(2, combinations[0].AccompanyingVariableCases.Count);
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

            IList<IQuasiPermanentCombination> combinations = Create();

            // Act
            IList<ILoad> loads = combinations[0].GetFactoredLoads();

            // Assert
            // LC1: DL + SDL + 0.3·Q + 0.2·S
            int i = 0;
            TestFactoredLoad(loads[i++], 1.0, dl);
            TestFactoredLoad(loads[i++], 1.0, sdl);
            TestFactoredLoad(loads[i++], 0.3, ll);
            TestFactoredLoad(loads[i++], 0.2, s);
        }

        private void TestFactoredLoad(ILoad actual, double factor, ILoad expectedUnfactored)
        {
            Assert.Equivalent(
                expectedUnfactored.Factor(new Ratio(factor, RatioUnit.DecimalFraction)),
                actual);
        }
    }
}

