using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateRectangularHollow(IRectangularHollow profile)
        {
            return new Perimeter(
                new LocalPolyline2d(PerimeterFactoryUtility.CreateRectanglePoints(profile.Height, profile.Width)),
                new List<ILocalPolyline2d>() {
                    new LocalPolyline2d(PerimeterFactoryUtility.CreateRectanglePoints(
                        profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness))
                });
        }
    }
}
