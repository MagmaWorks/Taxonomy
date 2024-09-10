namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateRectangle(IRectangle profile)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateRectanglePoints(profile.Height, profile.Width));
        }
    }
}
