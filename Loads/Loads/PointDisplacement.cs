namespace MagmaWorks.Taxonomy.Loads
{
    public class PointDisplacement : PointDisplacement2d, IPointDisplacement
    {
        public Length Y { get; set; } = Length.Zero;

        public PointDisplacement(Length x, Length y, Length z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override ILoad Factor(Ratio factor) => new PointDisplacement(
            this.X * factor.DecimalFractions,
            this.Y * factor.DecimalFractions,
            this.Z * factor.DecimalFractions)
        {
            Label = this.Label,
        };
    }
}
