namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateEllipse(IEllipse profile, int divisions)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateEllipsePoints(profile.Height, profile.Width, divisions));
        }
    }
}
