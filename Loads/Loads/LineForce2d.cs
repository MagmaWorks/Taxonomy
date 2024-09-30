using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class LineForce2d : ILineForce2d
    {
        public string Label { get; set; } = string.Empty;
        public LoadApplication Application { get; set; } = LoadApplication.Global;
        public ForcePerLength X { get; set; } = ForcePerLength.Zero;
        public ForcePerLength Z { get; set; } = ForcePerLength.Zero;

        internal LineForce2d() { }

        public LineForce2d(ForcePerLength z)
        {
            Z = z;
        }

        public LineForce2d(ForcePerLength x, ForcePerLength z, LoadApplication application)
        {
            X = x;
            Z = z;
            Application = application;
        }

        public static implicit operator LineForce2d(ForcePerLength f)
        {
            return new LineForce2d(f);
        }

        public virtual ILoad Factor(Ratio factor) => new LineForce2d()
        {
            Label = this.Label,
            Application = this.Application,
            X = this.X * factor.DecimalFractions,
            Z = this.Z * factor.DecimalFractions,
        };
    }
}
