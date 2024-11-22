using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;
using OasysUnits;
using OasysUnits.Units;

namespace ProfileTests
{
    public class PerimeterTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            LengthUnit unit = LengthUnit.Centimeter;
            var solidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(-50, unit)},
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(-50, unit)},
            });
            var voidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(-15, unit)},
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(-15, unit)},
            });

            // Act
            IPerimeter profile = new Perimeter(solidEdge, new List<ILocalPolygon2d>() { voidEdge });

            // Assert
            Assert.Single(profile.VoidEdges);
            Assert.Equal(5, profile.OuterEdge.Points.Count);
            Assert.Equal(5, profile.VoidEdges[0].Points.Count);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            LengthUnit unit = LengthUnit.Centimeter;
            var solidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(-50, unit)},
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(-50, unit)},
            });
            var voidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(-15, unit)},
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(-15, unit)},
            });

            // Act
            IPerimeter prfl = new Perimeter(solidEdge, new List<ILocalPolygon2d>() { voidEdge });
            string json = prfl.ToJson();
            IPerimeter prflDeserialized = json.FromJson<IPerimeter>();

            // Assert
            Assert.Single(prflDeserialized.VoidEdges);
            Assert.Equal(5, prflDeserialized.OuterEdge.Points.Count);
            Assert.Equal(5, prflDeserialized.VoidEdges[0].Points.Count);
            Assert.Equivalent(prfl, prflDeserialized);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            LengthUnit unit = LengthUnit.Centimeter;
            var solidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(-50, unit)},
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(-50, unit)},
            });
            var voidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(-15, unit)},
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(-15, unit)},
            });

            // Act
            IPerimeter prfl = new Perimeter(solidEdge, new List<ILocalPolygon2d>() { voidEdge });
            string json = prfl.ToJson();
            IPerimeter prflDeserialized = json.FromJson<Perimeter>();

            // Assert
            Assert.Single(prflDeserialized.VoidEdges);
            Assert.Equal(5, prflDeserialized.OuterEdge.Points.Count);
            Assert.Equal(5, prflDeserialized.VoidEdges[0].Points.Count);
            Assert.Equivalent(prfl, prflDeserialized);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            LengthUnit unit = LengthUnit.Centimeter;
            var solidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(50, unit)},
                new LocalPoint2d() { Y = new Length(-25, unit), Z = new Length(-50, unit)},
                new LocalPoint2d() { Y = new Length(25, unit), Z = new Length(-50, unit)},
            });
            var voidEdge = new LocalPolygon2d(new List<ILocalPoint2d>()
            {
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(15, unit)},
                new LocalPoint2d() { Y = new Length(-10, unit), Z = new Length(-15, unit)},
                new LocalPoint2d() { Y = new Length(10, unit), Z = new Length(-15, unit)},
            });

            // Act
            IPerimeter prfl = new Perimeter(solidEdge, new List<ILocalPolygon2d>() { voidEdge });
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Single(perimeter.VoidEdges);
            Assert.Equal(5, perimeter.OuterEdge.Points.Count);
            Assert.Equal(5, perimeter.VoidEdges[0].Points.Count);
            Assert.Equivalent(prfl, perimeter);
        }
    }
}
