using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Line2dForce : ILine2dForce
    {
        public string Label { get; set; }
        public LoadApplication Application { get; set; } = LoadApplication.Global;
        public ForcePerLength X { get; set; } = ForcePerLength.Zero;
        public ForcePerLength Z { get; set; } = ForcePerLength.Zero;

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

        public virtual ILoad Factor(Ratio factor) => new Line2dForce()
        {
            Label = this.Label,
            Application = this.Application,
            X = this.X * factor.DecimalFractions,
            Z = this.Z * factor.DecimalFractions,
        };
    }
}
