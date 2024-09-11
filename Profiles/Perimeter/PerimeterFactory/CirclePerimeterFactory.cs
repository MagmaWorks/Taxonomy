namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateCircle(ICircle profile, int divisions)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateCirclePoints(profile.Diameter, divisions));
        }
    }
}
