using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateRectangularHollow(IRectangularHollow profile)
        {
            return new Perimeter(
                new Polygon2d(PerimeterFactoryUtility.CreateRectanglePoints(profile.Height, profile.Width)),
                new List<IPolygon2d>() {
                    new Polygon2d(PerimeterFactoryUtility.CreateRectanglePoints(
                        profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness))
                });
        }
    }
}
