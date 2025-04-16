namespace MagmaWorks.Taxonomy.Loads
{
    public class ColumnLoad : IColumnLoad
    {
        public string Label { get; set; } = string.Empty;
        public Force Force { get; set; } = Force.Zero;
        public IPointMoment2d TopMoment { get; set; } = new PointMoment2d();
        public IPointMoment2d BottomMoment { get; set; } = new PointMoment2d();

        private ColumnLoad() { }

        public ColumnLoad(Force force)
        {
            Force = force;
        }

        public ColumnLoad(Force force, IPointMoment2d topMoment, IPointMoment2d bottomMoment)
        {
            Force = force;
            TopMoment = topMoment;
            BottomMoment = bottomMoment;
        }

        public static implicit operator ColumnLoad(Force f)
        {
            return new ColumnLoad(f);
        }

        public ILoad Factor(Ratio factor)
        {
            return new ColumnLoad()
            {
                Force = this.Force * factor.DecimalFractions,
                TopMoment = (IPointMoment2d)this.TopMoment.Factor(factor),
                BottomMoment = (IPointMoment2d)this.BottomMoment.Factor(factor),
                Label = this.Label
            };
        }
    }
}
