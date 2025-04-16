namespace MagmaWorks.Taxonomy.Loads
{
    public class Gravity2d : IGravity2d
    {
        public string Label { get; set; } = string.Empty;
        public Ratio X { get; set; } = Ratio.Zero;
        public Ratio Z { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);

        public Gravity2d() { }

        public Gravity2d(Ratio z)
        {
            Z = z;
        }

        public virtual ILoad Factor(Ratio factor) => new Gravity2d()
        {
            Label = this.Label,
            X = this.X * factor.DecimalFractions,
            Z = this.Z * factor.DecimalFractions,
        };
    }
}
