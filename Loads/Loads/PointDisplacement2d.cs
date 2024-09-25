using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PointDisplacement2d : IPointDisplacement2d
    {
        public char Symbol { get; set; }
        public Length X { get; set; } = Length.Zero;
        public Length Z { get; set; } = Length.Zero;

        internal PointDisplacement2d() { }

        public PointDisplacement2d(Length x, Length z)
        {
            X = x;
            Z = z;
        }
    }
}
