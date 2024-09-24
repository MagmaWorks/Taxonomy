using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Point2dDisplacement : IPoint2dDisplacement
    {
        public Length X { get; set; } = Length.Zero;
        public Length Z { get; set; } = Length.Zero;

        internal Point2dDisplacement() { }

        public Point2dDisplacement(Length x, Length z)
        {
            X = x;
            Z = z;
        }
    }
}
