using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateRectangularHollow(IRectangularHollow profile)
        {
            return new Perimeter(
                new LocalPolygon2d(PerimeterFactoryUtility.CreateRectanglePoints(profile.Height, profile.Width)),
                new List<ILocalPolygon2d>() {
                    new LocalPolygon2d(PerimeterFactoryUtility.CreateRectanglePoints(
                        profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness))
                });
        }
    }
}
