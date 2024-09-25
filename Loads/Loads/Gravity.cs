using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Gravity : Gravity2d, IGravity
    {
        public Ratio Y { get; } = Ratio.Zero;

        public Gravity() { }

        public Gravity(Ratio z) : base(z) { }

    }
}
