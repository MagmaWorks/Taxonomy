namespace MagmaWorks.Taxonomy.Loads
{
    public class PointForce : PointForce2d, IPointForce
    {
        public Force Y { get; set; } = Force.Zero;

        public PointForce(Force x, Force y, Force z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator PointForce(Force f)
        {
            return new PointForce(Force.Zero, Force.Zero, f);
        }

        public override ILoad Factor(Ratio factor) => new PointForce(
            this.X * factor.DecimalFractions,
            this.Y * factor.DecimalFractions,
            this.Z * factor.DecimalFractions)
        {
            Label = this.Label,
        };
    }
}
