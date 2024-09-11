namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateCustomI(ICustomI profile)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateCustomIPoints(profile.Height, profile.TopFlangeWidth, profile.BottomFlangeWidth,
                profile.TopFlangeThickness, profile.BottomFlangeThickness, profile.WebThickness));
        }
    }
}
