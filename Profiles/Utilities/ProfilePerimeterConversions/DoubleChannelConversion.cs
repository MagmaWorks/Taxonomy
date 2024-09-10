namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class DoubleChannelConversion
    {
        public static (IPerimeter, IPerimeter) GetPerimeter<T>(this T profile) where T : IDoubleChannel
        {
            return DoubleAngleConversion.GetBackToBackPerimeter(((IChannel)profile).GetPerimeter().OuterEdge.Points, profile.BackToBackDistance);
        }
    }
}
