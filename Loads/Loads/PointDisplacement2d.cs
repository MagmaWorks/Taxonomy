using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PointDisplacement2d : IPointDisplacement2d
    {
        public string Label { get; set; } = string.Empty;
        public Length X { get; set; } = Length.Zero;
        public Length Z { get; set; } = Length.Zero;

        internal PointDisplacement2d() { }

        public PointDisplacement2d(Length x, Length z)
        {
            X = x;
            Z = z;
        }

        public virtual ILoad Factor(Ratio factor) => new PointDisplacement2d()
        {
            Label = this.Label,
            X = this.X * factor.DecimalFractions,
            Z = this.Z * factor.DecimalFractions
        };
    }
}
