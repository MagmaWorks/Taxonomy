namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateRoundedRectangle(IRoundedRectangle profile, int filletDivisions)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateRoundedRectanglePoints(profile.Height, profile.Width, profile.FlatHeight, profile.FlatWidth, filletDivisions));
        }
    }
}
