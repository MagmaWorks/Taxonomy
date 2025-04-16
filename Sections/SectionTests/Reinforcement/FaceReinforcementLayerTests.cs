using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Sections.Exceptions;
using MagmaWorks.Taxonomy.Sections.Reinforcement;
using UnitsNet;
using UnitsNet.Units;
using Angle = MagmaWorks.Taxonomy.Profiles.Angle;

namespace SectionTests.ReinforcementTests
{
    public class FaceReinforcementLayerTests
    {
        [Fact]
        public void InvalidProfileTypeTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Circle(new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            int numberOfBars = 8;

            // Act
            var layer = new FaceReinforcementLayer(SectionFace.Top, rebar, numberOfBars);

            // Assert
            Assert.Throws<InvalidProfileTypeException>(() => layer.GetPath(profile, cover));
        }

        [Theory]
        [InlineData(SectionFace.Top, -200, 400, 200, 400)]
        [InlineData(SectionFace.Right, 200, 400, 200, -400)]
        [InlineData(SectionFace.Bottom, 200, -400, -200, -400)]
        [InlineData(SectionFace.Left, -200, -400, -200, 400)]
        public void GetPathFromRectangleTest(SectionFace face, double expectedStartY,
            double expectedStartZ, double expectedEndY, double expectedEndZ)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Rectangle(new Length(400, u), new Length(800, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 6;

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(2, path.Points.Count);
            Assert.Equal(expectedStartY, path.Points[0].Y.As(u), 2);
            Assert.Equal(expectedStartZ, path.Points[0].Z.As(u), 2);
            Assert.Equal(expectedEndY, path.Points[1].Y.As(u), 2);
            Assert.Equal(expectedEndZ, path.Points[1].Z.As(u), 2);
        }

        [Theory]
        [InlineData(SectionFace.Left, 0, 0, 0, 400)]
        [InlineData(SectionFace.Top, 0, 400, 10, 400)]
        [InlineData(SectionFace.Right, 10, 400, 10, 20)]
        [InlineData(SectionFace.Bottom, 800, 0, 0, 0)]
        public void GetPathFromAngleTest(SectionFace face, double expectedStartY,
           double expectedStartZ, double expectedEndY, double expectedEndZ)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Angle(
                new Length(400, u), new Length(800, u),
                new Length(10, u), new Length(20, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 6;

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(2, path.Points.Count);
            Assert.Equal(expectedStartY, path.Points[0].Y.As(u), 2);
            Assert.Equal(expectedStartZ, path.Points[0].Z.As(u), 2);
            Assert.Equal(expectedEndY, path.Points[1].Y.As(u), 2);
            Assert.Equal(expectedEndZ, path.Points[1].Z.As(u), 2);
        }

        [Theory]
        [InlineData(SectionFace.Top, -200, 400, 200, 400)]
        [InlineData(SectionFace.Right, 5, 380, 5, -380)]
        [InlineData(SectionFace.Bottom, 200, -400, -200, -400)]
        [InlineData(SectionFace.Left, -5, -380, -5, 380)]
        public void GetPathFromITest(SectionFace face, double expectedStartY,
            double expectedStartZ, double expectedEndY, double expectedEndZ)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new I(new Length(800, u), new Length(400, u),
                new Length(20, u), new Length(10, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 6;

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(2, path.Points.Count);
            Assert.Equal(expectedStartY, path.Points[0].Y.As(u), 2);
            Assert.Equal(expectedStartZ, path.Points[0].Z.As(u), 2);
            Assert.Equal(expectedEndY, path.Points[1].Y.As(u), 2);
            Assert.Equal(expectedEndZ, path.Points[1].Z.As(u), 2);
        }

        [Theory]
        [InlineData(SectionFace.Top, -300, 400, 300, 400)]
        [InlineData(SectionFace.Right, 5, 380, 5, -385)]
        [InlineData(SectionFace.Bottom, 150, -400, -150, -400)]
        [InlineData(SectionFace.Left, -5, -385, -5, 380)]
        public void GetPathFromCustomITest(SectionFace face, double expectedStartY,
            double expectedStartZ, double expectedEndY, double expectedEndZ)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new CustomI(new Length(800, u), new Length(600, u),
                new Length(300, u), new Length(20, u), new Length(15, u), new Length(10, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 6;

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(2, path.Points.Count);
            Assert.Equal(expectedStartY, path.Points[0].Y.As(u), 2);
            Assert.Equal(expectedStartZ, path.Points[0].Z.As(u), 2);
            Assert.Equal(expectedEndY, path.Points[1].Y.As(u), 2);
            Assert.Equal(expectedEndZ, path.Points[1].Z.As(u), 2);
        }

        [Theory]
        [InlineData(SectionFace.Top, -400, 0, 400, 0)]
        [InlineData(SectionFace.Right, 5, -20, 5, -600)]
        [InlineData(SectionFace.Bottom, 5, -600, -5, -600)]
        [InlineData(SectionFace.Left, -5, -600, -5, -20)]
        public void GetPathFromTeeTest(SectionFace face, double expectedStartY,
            double expectedStartZ, double expectedEndY, double expectedEndZ)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Tee(new Length(600, u), new Length(800, u),
                new Length(20, u), new Length(10, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 6;

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(2, path.Points.Count);
            Assert.Equal(expectedStartY, path.Points[0].Y.As(u), 2);
            Assert.Equal(expectedStartZ, path.Points[0].Z.As(u), 2);
            Assert.Equal(expectedEndY, path.Points[1].Y.As(u), 2);
            Assert.Equal(expectedEndZ, path.Points[1].Z.As(u), 2);
        }

        [Theory]
        [InlineData(SectionFace.Top, -300, 100, 300, 100)]
        [InlineData(SectionFace.Right, 300, 100, 200, -100)]
        [InlineData(SectionFace.Bottom, 200, -100, -200, -100)]
        [InlineData(SectionFace.Left, -200, -100, -300, 100)]
        public void GetPathFromTrapezoidTest(SectionFace face, double expectedStartY,
            double expectedStartZ, double expectedEndY, double expectedEndZ)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Trapezoid(new Length(600, u), new Length(400, u), new Length(200, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 6;

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(2, path.Points.Count);
            Assert.Equal(expectedStartY, path.Points[0].Y.As(u), 2);
            Assert.Equal(expectedStartZ, path.Points[0].Z.As(u), 2);
            Assert.Equal(expectedEndY, path.Points[1].Y.As(u), 2);
            Assert.Equal(expectedEndZ, path.Points[1].Z.As(u), 2);
        }

        [Theory]
        [InlineData(SectionFace.Top, 5,
            new double[] { -200, -100, 0, 100, 200 }, new double[] { 400, 400, 400, 400, 400 })]
        [InlineData(SectionFace.Bottom, 5,
            new double[] { 200, 100, 0, -100, -200 }, new double[] { -400, -400, -400, -400, -400 })]
        [InlineData(SectionFace.Right, 3,
            new double[] { 200, 200, 200 }, new double[] { 200, 0, -200 })]
        [InlineData(SectionFace.Left, 3,
            new double[] { -200, -200, -200 }, new double[] { -200, 0, 200 })]
        public void GetRebarsByCountTest(SectionFace face, int expectedNoBars,
            double[] expectedYs, double[] expectedZs)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Rectangle(new Length(400, u), new Length(800, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 5;

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(expectedNoBars, rebars.Count);
            for (int i = 0; i < expectedNoBars; i++)
            {
                Assert.Equal(expectedYs[i], rebars[i].Position.Y.As(u), 2);
                Assert.Equal(expectedZs[i], rebars[i].Position.Z.As(u), 2);
            }
        }

        [Theory]
        [InlineData(SectionFace.Top, 3,
            new double[] { -200, 0, 200 }, new double[] { 400, 400, 400 })]
        [InlineData(SectionFace.Bottom, 3,
            new double[] { 200, 0, -200 }, new double[] { -400, -400, -400 })]
        [InlineData(SectionFace.Right, 3,
            new double[] { 200, 200, 200 }, new double[] { 200, 0, -200 })]
        [InlineData(SectionFace.Left, 3,
            new double[] { -200, -200, -200 }, new double[] { -200, 0, 200 })]
        public void GetRebarsBySpacingTest(SectionFace face, int expectedNoBars,
            double[] expectedYs, double[] expectedZs)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Rectangle(new Length(400, u), new Length(800, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            Length spacing = new Length(200, u);

            // Act
            var layer = new FaceReinforcementLayer(face, rebar, spacing);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(expectedNoBars, rebars.Count);
            for (int i = 0; i < expectedNoBars; i++)
            {
                Assert.Equal(expectedYs[i], rebars[i].Position.Y.As(u), 2);
                Assert.Equal(expectedZs[i], rebars[i].Position.Z.As(u), 2);
            }
        }
    }
}
