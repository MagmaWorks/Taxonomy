namespace MagmaWorks.Taxonomy.Loads
{
    public class PointMoment : PointMoment2d, IPointMoment
    {
        public Moment Xx { get; set; } = Moment.Zero;

        public PointMoment(Moment xx, Moment yy, Moment zz)
        {
            Xx = xx;
            Yy = yy;
            Zz = zz;
        }

        public override ILoad Factor(Ratio factor) => new PointMoment(
            this.Xx * factor.DecimalFractions,
            this.Yy * factor.DecimalFractions,
            this.Zz * factor.DecimalFractions)
        {
            Label = this.Label,
        };
    }
}
