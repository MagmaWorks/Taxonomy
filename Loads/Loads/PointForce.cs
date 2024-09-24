using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PointForce : Point2dForce, IPointForce
    {
        public Force Y { get; set; } = Force.Zero;

        public PointForce(Force x, Force y, Force z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator PointForce(Force f)
        {
            return new PointForce(Force.Zero, Force.Zero, f);
        }
    }
}
