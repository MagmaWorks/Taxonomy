namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateRectangle(IRectangle profile)
        {
            return new Perimeter(PerimeterFactoryUtility.CreateRectanglePoints(profile.Height, profile.Width));
        }
    }
}
