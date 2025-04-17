namespace MagmaWorks.Taxonomy.Loads
{
    public class PointMoment2d : IPointMoment2d
    {
        public string Label { get; set; } = string.Empty;
        public Moment Yy { get; set; } = Moment.Zero;
        public Moment Zz { get; set; } = Moment.Zero;

        internal PointMoment2d() { }

        public PointMoment2d(Moment yy, Moment zz)
        {
            Yy = yy;
            Zz = zz;
        }

        public virtual ILoad Factor(Ratio factor) => new PointMoment2d()
        {
            Label = this.Label,
            Yy = this.Yy * factor.DecimalFractions,
            Zz = this.Zz * factor.DecimalFractions
        };
    }
}
