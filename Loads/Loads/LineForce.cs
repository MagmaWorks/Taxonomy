namespace MagmaWorks.Taxonomy.Loads
{
    public class LineForce : LineForce2d, ILineForce
    {

        public ForcePerLength Y { get; set; } = ForcePerLength.Zero;

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

        public override ILoad Factor(Ratio factor) => new LineForce()
        {
            Label = this.Label,
            Application = this.Application,
            X = this.X * factor.DecimalFractions,
            Y = this.Y * factor.DecimalFractions,
            Z = this.Z * factor.DecimalFractions,
        };
    }
}
