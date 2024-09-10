namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateCustomI(ICustomI profile)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateCustomIPoints(profile.Height, profile.TopFlangeWidth, profile.BottomFlangeWidth,
                profile.TopFlangeThickness, profile.BottomFlangeThickness, profile.WebThickness));
        }
    }
}
