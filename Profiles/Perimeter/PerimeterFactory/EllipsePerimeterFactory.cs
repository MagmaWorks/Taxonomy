namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateEllipse(IEllipse profile, int divisions)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateEllipsePoints(profile.Height, profile.Width, divisions));
        }
    }
}
