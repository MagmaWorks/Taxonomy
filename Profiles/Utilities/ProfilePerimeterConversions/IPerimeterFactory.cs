namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateI(II profile)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateCustomIPoints(profile.Height, profile.Width, profile.Width,
                profile.FlangeThickness, profile.FlangeThickness, profile.WebThickness));
        }
    }
}
