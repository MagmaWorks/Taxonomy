using MagmaWorks.Geometry;
using OasysUnits;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class IConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : II
        {
            return new Perimeter(CustomIConversion.GetIPoints(profile.Height, profile.Width, profile.Width,
                profile.FlangeThickness, profile.FlangeThickness, profile.WebThickness));
        }
    }
}
