using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PointDisplacement : Point2dDisplacement, IPointDisplacement
    {
        public Length Y { get; set; } = Length.Zero;

        public PointDisplacement(Length x, Length y, Length z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
