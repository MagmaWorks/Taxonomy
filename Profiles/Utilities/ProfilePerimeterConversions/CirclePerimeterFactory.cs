namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateCircle(ICircle profile, int divisions)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateCirclePoints(profile.Diameter, divisions));
        }
    }
}
