using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class AreaForce : IAreaForce
    {
        public string Label { get; set; }
        public LoadApplication Application { get; set; } = LoadApplication.Local;
        public Pressure X { get; set; } = Pressure.Zero;
        public Pressure Y { get; set; } = Pressure.Zero;
        public Pressure Z { get; set; } = Pressure.Zero;

        private AreaForce() { }

        public AreaForce(Pressure z)
        {
            Z = z;
        }
        public AreaForce(Pressure x, Pressure y, Pressure z, LoadApplication application)
        {
            X = x;
            Y = y;
            Z = z;
            Application = application;
        }

        public static implicit operator AreaForce(Pressure f)
        {
            return new AreaForce(f);
        }

        public ILoad Factor(Ratio factor)
        {
            return new AreaForce()
            {
                Label = this.Label,
                Application = this.Application,
                X = this.X * factor.DecimalFractions,
                Y = this.Y * factor.DecimalFractions,
                Z = this.Z * factor.DecimalFractions,
            };
        }
    }
}
