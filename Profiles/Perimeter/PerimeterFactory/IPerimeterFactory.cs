namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateI(II profile)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateCustomIPoints(profile.Height, profile.Width, profile.Width,
                profile.FlangeThickness, profile.FlangeThickness, profile.WebThickness));
        }
    }
}
