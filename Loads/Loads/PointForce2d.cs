using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PointForce2d : IPointForce2d
    {
        public string Label { get; set; }
        public Force X { get; set; } = Force.Zero;
        public Force Z { get; set; } = Force.Zero;

        internal PointForce2d() { }

        public PointForce2d(Force z)
        {
            Z = z;
        }

        public PointForce2d(Force x, Force z)
        {
            X = x;
            Z = z;
        }

        public static implicit operator PointForce2d(Force f)
        {
            return new PointForce2d(f);
        }

        public virtual ILoad Factor(Ratio factor) => new PointForce2d()
        {
            Label = this.Label,
            X = this.X * factor.DecimalFractions,
            Z = this.Z * factor.DecimalFractions
        };
    }
}
