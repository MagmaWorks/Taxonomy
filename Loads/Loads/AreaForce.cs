namespace MagmaWorks.Taxonomy.Loads
{
    public class AreaForce : IAreaForce
    {
        public string Label { get; set; } = string.Empty;
        public LoadApplication Application { get; set; } = LoadApplication.Local;
        public ForcePerArea X { get; set; } = ForcePerArea.Zero;
        public ForcePerArea Y { get; set; } = ForcePerArea.Zero;
        public ForcePerArea Z { get; set; } = ForcePerArea.Zero;

        private AreaForce() { }

        public AreaForce(ForcePerArea z)
        {
            Z = z;
        }
        public AreaForce(ForcePerArea x, ForcePerArea y, ForcePerArea z, LoadApplication application)
        {
            X = x;
            Y = y;
            Z = z;
            Application = application;
        }

        public static implicit operator AreaForce(ForcePerArea f)
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
