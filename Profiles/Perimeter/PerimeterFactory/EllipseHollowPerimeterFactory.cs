﻿using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateEllipseHollow(IEllipseHollow profile, int divisions)
        {
            IList<ILocalPoint2d> outerEdge = PerimeterFactoryUtility.CreateEllipsePoints(profile.Height, profile.Width, divisions);
            IList<ILocalPoint2d> voidEdge = PerimeterFactoryUtility.CreateEllipsePoints(
                profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness, divisions);
            return new Perimeter(new LocalPolyline2d(outerEdge), new List<ILocalPolyline2d>() { new LocalPolyline2d(voidEdge) });
        }
    }
}
