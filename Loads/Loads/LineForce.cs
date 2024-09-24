using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class LineForce : Line2dForce, ILineForce
    {

        public ForcePerLength Y { get; } = ForcePerLength.Zero;

        private LineForce() { }

        public LineForce(ForcePerLength z) : base(z) { }

        public LineForce(ForcePerLength x, ForcePerLength y, ForcePerLength z, LoadApplication application)
        {
            X = x;
            Y = y;
            Z = z;
            Application = application;
        }

        public static implicit operator LineForce(ForcePerLength f)
        {
            return new LineForce(f);
        }
    }
}
