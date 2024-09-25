using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Line2dForce : ILine2dForce
    {
        public ForcePerLength X { get; set; } = ForcePerLength.Zero;
        public ForcePerLength Z { get; set; } = ForcePerLength.Zero;
        public LoadApplication Application { get; set; } = LoadApplication.Global;

        internal Line2dForce() { }

        public Line2dForce(ForcePerLength z)
        {
            Z = z;
        }

        public Line2dForce(ForcePerLength x, ForcePerLength z, LoadApplication application)
        {
            X = x;
            Z = z;
            Application = application;
        }

        public static implicit operator Line2dForce(ForcePerLength f)
        {
            return new Line2dForce(f);
        }
    }
}
