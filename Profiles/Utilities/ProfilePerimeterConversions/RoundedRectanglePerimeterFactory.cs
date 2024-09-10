namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateRoundedRectangle(IRoundedRectangle profile, int filletDivisions)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateRoundedRectanglePoints(profile.Height, profile.Width, profile.FlatHeight, profile.FlatWidth, filletDivisions));
        }
    }
}
