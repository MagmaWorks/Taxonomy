using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using OasysUnits;
using OasysUnits.Units;

namespace LoadCaseTests
{
    public class PermanentCaseTests
    {
        public static IPermanentCase CreateDLCase()
        {
            var loadCase = new PermanentCase()
            {
                Nickname = "DL"
            };

            loadCase.Loads.Add(new Gravity());
            return loadCase;
        }

        public static IPermanentCase CreateSDLCase()
        {
            var loadCase = new PermanentCase()
            {
                Nickname = "SDL",
                Name = "Superimposed Dead Load"
            };

            loadCase.Loads.Add(new AreaForce(new Pressure(2.5, PressureUnit.KilonewtonPerSquareMeter)));
            return loadCase;
        }

        [Fact]
        public void CreatePermanentCaseTest()
        {
            // Assemble
            // Act
            IPermanentCase permanentCase = CreateDLCase();

            // Assert
            Assert.Equal("DL", permanentCase.Nickname);
            Assert.Equal("Dead Load", permanentCase.Name);
            Assert.False(permanentCase.IsFavourable);
            Assert.False(permanentCase.IsHorizontal);
            Assert.Single(permanentCase.Loads);
            Assert.Equivalent(new Gravity(), permanentCase.Loads.FirstOrDefault());
        }

        [Fact]
        public void CreateSDLCaseTest()
        {
            // Assemble
            // Act
            IPermanentCase permanentCase = CreateSDLCase();

            // Assert
            Assert.Equal("SDL", permanentCase.Nickname);
            Assert.Equal("Superimposed Dead Load", permanentCase.Name);
            Assert.False(permanentCase.IsFavourable);
            Assert.False(permanentCase.IsHorizontal);
            Assert.Single(permanentCase.Loads);
            Assert.Equivalent(new AreaForce(new Pressure(2.5, PressureUnit.KilonewtonPerSquareMeter)),
                permanentCase.Loads.FirstOrDefault());
        }
    }
}
