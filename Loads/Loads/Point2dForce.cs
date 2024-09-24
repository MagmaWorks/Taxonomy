using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Point2dForce : IPoint2dForce
    {
        public Force X { get; set; } = Force.Zero;
        public Force Z { get; set; } = Force.Zero;

        internal Point2dForce() { }

        public Point2dForce(Force z) {
            Z = z;
        }

        public Point2dForce(Force x, Force z)
        {
            X = x;
            Z = z;
        }

        public static implicit operator Point2dForce(Force f)
        {
            return new Point2dForce(f);
        }
    }
}
