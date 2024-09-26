using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Gravity : Gravity2d, IGravity
    {
        public Ratio Y { get; set; } = Ratio.Zero;

        public Gravity() { }

        public Gravity(Ratio z) : base(z) { }

        public override ILoad Factor(Ratio factor)
        {
            return new Gravity()
            {
                Label = this.Label,
                X = this.X * factor.DecimalFractions,
                Y = this.Y * factor.DecimalFractions,
                Z = this.Z * factor.DecimalFractions,
            };
        }
    }
}
