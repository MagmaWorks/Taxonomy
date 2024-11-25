using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Sections.Reinforcement;
using OasysUnits.Units;
using OasysUnits;

namespace SectionTests.ReinforcementTests
{
    public class PerimeterReinforcementLayerTests
    {
        [Fact]
        public void GetPathFromCircleByCountTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Circle(new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            int numberOfBars = 8;

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(numberOfBars + 1, path.Points.Count);
            int i = 0;
            Assert.Equal(355.62, path.Points[i].Y.As(u), 2);
            Assert.Equal(0, path.Points[i++].Z.As(u), 2);
            Assert.Equal(251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(-251.46, path.Points[i++].Z.As(u), 2);
            Assert.Equal(0, path.Points[i].Y.As(u), 2);
            Assert.Equal(-355.62, path.Points[i++].Z.As(u), 2);
            Assert.Equal(-251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(-251.46, path.Points[i++].Z.As(u), 2);
            Assert.Equal(-355.62, path.Points[i].Y.As(u), 2);
            Assert.Equal(0, path.Points[i++].Z.As(u), 2);
            Assert.Equal(-251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(251.46, path.Points[i++].Z.As(u), 2);
            Assert.Equal(0, path.Points[i].Y.As(u), 2);
            Assert.Equal(355.62, path.Points[i++].Z.As(u), 2);
            Assert.Equal(251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(251.46, path.Points[i++].Z.As(u), 2);
        }

        [Fact]
        public void GetPathFromCircleBySpacingTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Circle(new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            Length spacing = new Length(300, u);

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, spacing);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(9, path.Points.Count);
            int i = 0;
            Assert.Equal(355.62, path.Points[i].Y.As(u), 2);
            Assert.Equal(0, path.Points[i++].Z.As(u), 2);
            Assert.Equal(251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(-251.46, path.Points[i++].Z.As(u), 2);
            Assert.Equal(0, path.Points[i].Y.As(u), 2);
            Assert.Equal(-355.62, path.Points[i++].Z.As(u), 2);
            Assert.Equal(-251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(-251.46, path.Points[i++].Z.As(u), 2);
            Assert.Equal(-355.62, path.Points[i].Y.As(u), 2);
            Assert.Equal(0, path.Points[i++].Z.As(u), 2);
            Assert.Equal(-251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(251.46, path.Points[i++].Z.As(u), 2);
            Assert.Equal(0, path.Points[i].Y.As(u), 2);
            Assert.Equal(355.62, path.Points[i++].Z.As(u), 2);
            Assert.Equal(251.46, path.Points[i].Y.As(u), 2);
            Assert.Equal(251.46, path.Points[i++].Z.As(u), 2);
        }

        [Fact]
        public void GetPathFromRectangleTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Rectangle(new Length(400, u), new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            int numberOfBars = 8;

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);

            // Assert
            Assert.Equal(5, path.Points.Count);
            double toRebarCentre = 35.0 + 12.0 / 2;
            int i = 0;
            Assert.Equal(-400/2 + toRebarCentre, path.Points[i].Y.As(u), 2);
            Assert.Equal(800/2 - toRebarCentre, path.Points[i++].Z.As(u), 2);
            Assert.Equal(400 / 2 - toRebarCentre, path.Points[i].Y.As(u), 2);
            Assert.Equal(800 / 2 - toRebarCentre, path.Points[i++].Z.As(u), 2);
            Assert.Equal(400 / 2 - toRebarCentre, path.Points[i].Y.As(u), 2);
            Assert.Equal(-800 / 2 + toRebarCentre, path.Points[i++].Z.As(u), 2);
            Assert.Equal(-400 / 2 + toRebarCentre, path.Points[i].Y.As(u), 2);
            Assert.Equal(-800 / 2 + toRebarCentre, path.Points[i++].Z.As(u), 2);
        }

        [Fact]
        public void GetRebarsFromCircleByCountTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Circle(new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            int numberOfBars = 8;

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(numberOfBars, rebars.Count);
            int i = 0;
            Assert.Equal(355.62, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(0, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-251.46, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-355.62, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-251.46, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-355.62, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(0, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(251.46, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(355.62, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(251.46, rebars[i++].Position.Z.As(u), 2);
        }

        [Fact]
        public void GetRebarsFromCircleBySpacingTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Circle(new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            Length spacing = new Length(300, u);

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, spacing);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(8, rebars.Count);
            int i = 0;
            Assert.Equal(355.62, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(0, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-251.46, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-355.62, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-251.46, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-355.62, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(0, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(251.46, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(355.62, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(251.46, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(251.46, rebars[i++].Position.Z.As(u), 2);
        }

        [Fact]
        public void GetRebarsFromRectangleByCountTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Rectangle(new Length(400, u), new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            int numberOfBars = 6;

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(6, rebars.Count);
            double toRebarCentre = 35.0 + 12.0 / 2;
            int i = 0;
            Assert.Equal(-400 / 2 + toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(800 / 2 - toRebarCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(400 / 2 - toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(800 / 2 - toRebarCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(400 / 2 - toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(0, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(400 / 2 - toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + toRebarCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-400 / 2 + toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + toRebarCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-400 / 2 + toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(0, rebars[i++].Position.Z.As(u), 2);
        }

        [Fact]
        public void GetRebarsFromRectangleByCountBelowNoOfEdgePointsTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IProfile profile = new Rectangle(new Length(400, u), new Length(800, u));
            Length cover = new Length(35, u);
            IRebar rebar = RebarTests.CreateRebar(12);
            int numberOfBars = 2;

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(4, rebars.Count);
            double toRebarCentre = 35.0 + 12.0 / 2;
            int i = 0;
            Assert.Equal(-400 / 2 + toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(800 / 2 - toRebarCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(400 / 2 - toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(800 / 2 - toRebarCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(400 / 2 - toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + toRebarCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(-400 / 2 + toRebarCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + toRebarCentre, rebars[i++].Position.Z.As(u), 2);
        }

        [Fact]
        public void GetRebarsFromPerimeterWithOneSideLongerByCountTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            var solidEdge = new LocalPolyline2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(0, u), Z = new Length(400, u)},
                new LocalPoint2d() { Y = new Length(500, u), Z = new Length(1000, u)},
                new LocalPoint2d() { Y = new Length(500, u), Z = new Length(-1000, u)},
                new LocalPoint2d() { Y = new Length(0, u), Z = new Length(-400, u)},
            });

            IProfile profile = new Perimeter(solidEdge);
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 6;

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(6, rebars.Count);
            int i = 0;
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(400, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(1000, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(333.33, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-333.33, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-1000, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-400, rebars[i++].Position.Z.As(u), 2);
        }

        [Fact]
        public void GetRebarsFromPerimeterWithOneSideLongerByCountTest2()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            var solidEdge = new LocalPolyline2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(0, u), Z = new Length(400, u)},
                new LocalPoint2d() { Y = new Length(500, u), Z = new Length(1000, u)},
                new LocalPoint2d() { Y = new Length(500, u), Z = new Length(-1000, u)},
                new LocalPoint2d() { Y = new Length(0, u), Z = new Length(-400, u)},
            });

            IProfile profile = new Perimeter(solidEdge);
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 7;

            // Act
            var layer = new PerimeterReinforcementLayer(rebar, numberOfBars);
            ILocalPolyline2d path = layer.GetPath(profile, cover);
            IList<ILongitudinalReinforcement> rebars = layer.GetRebars(path);

            // Assert
            Assert.Equal(7, rebars.Count);
            int i = 0;
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(400, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(1000, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(333.33, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-333.33, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(500, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-1000, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-400, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(0, rebars[i++].Position.Z.As(u), 2);
        }
    }
}
