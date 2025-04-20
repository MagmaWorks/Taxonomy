namespace ProfileTests
{
    public class DescriptionTests
    {
        [Fact]
        public void RectangleProfileDescriptionTest()
        {
            // Assemble
            var h = new Length(20, LengthUnit.Centimeter);
            var w = new Length(500.4, LengthUnit.Millimeter);
            var prfl = new Rectangle(w, h);

            // Act
            string description = prfl.Description;

            // Assert
            Assert.Equal("500 × 200 mm", description);
        }

        [Fact]
        public void CircleProfileDescriptionTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            ICircle prfl = new Circle(dia);

            // Act
            string description = prfl.Description;

            // Assert
            Assert.Equal("Ø " + new Ratio(2.3, RatioUnit.DecimalFraction) + " cm", description);
        }

        [Fact]
        public void CircularHollowProfileDescriptionTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);
            ICircularHollow prfl = new CircularHollow(dia, thk);

            // Act
            string description = prfl.Description;

            // Assert
            Assert.Equal("Ø " + new Ratio(2.3, RatioUnit.DecimalFraction) + " × " + new Ratio(1.1, RatioUnit.DecimalFraction) + " cm", description);
        }

        [Fact]
        public void BackToBackAngleProfileDescriptionTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);
            IDoubleAngle prfl = new DoubleAngle(h, w, webThk, flangeThk, dist);

            // Act
            string description = prfl.Description;

            // Assert
            Assert.Equal("" + new Ratio(2.3, RatioUnit.DecimalFraction) + " × " + new Ratio(5.4, RatioUnit.DecimalFraction) + " × " + new Ratio(1.1, RatioUnit.DecimalFraction) + " × " + new Ratio(1.5, RatioUnit.DecimalFraction) + " cm B2B " + new Ratio(2.5, RatioUnit.DecimalFraction) + " mm", description);
        }

        [Fact]
        public void BackToBackChannelProfileDescriptionTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);
            IDoubleChannel prfl = new DoubleChannel(h, w, webThk, flangeThk, dist);

            // Act
            string description = prfl.Description;

            // Assert
            Assert.Equal("" + new Ratio(2.3, RatioUnit.DecimalFraction) + " × " + new Ratio(5.4, RatioUnit.DecimalFraction) + " × " + new Ratio(1.1, RatioUnit.DecimalFraction) + " × " + new Ratio(1.5, RatioUnit.DecimalFraction) + " cm B2B " + new Ratio(2.5, RatioUnit.DecimalFraction) + " mm", description);
        }

        [Fact]
        public void TrapezoidProfileDescriptionTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);
            ITrapezoid prfl = new Trapezoid(wTop, wBottom, h);

            // Act
            string description = prfl.Description;

            // Assert
            Assert.Equal("" + new Ratio(5.4, RatioUnit.DecimalFraction) + " / " + new Ratio(50.0, RatioUnit.DecimalFraction).ToString("N1") + " × " + new Ratio(2.3, RatioUnit.DecimalFraction) + " cm", description);
        }

        [Fact]
        public void HE300BProfileDescriptionTest()
        {
            // Assemble
            var prfl = new HE300B();

            // Act
            string description = prfl.Description;

            // Assert
            Assert.Equal("HE 300 B", description);
        }
    }
}
