using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class ColumnLoad : IColumnLoad {
        public Force Force { get; set; } = Force.Zero;
        public IPoint2dMoment TopMoment { get; set; } = new Point2dMoment();
        public IPoint2dMoment BottomMoment { get; set; } = new Point2dMoment();

        private ColumnLoad() { }

        public ColumnLoad(Force force) {
            Force = force;
        }

        public ColumnLoad(Force force, IPoint2dMoment topMoment, IPoint2dMoment bottomMoment)
        {
            Force = force;
            TopMoment = topMoment;
            BottomMoment = bottomMoment;
        }

        public static implicit operator ColumnLoad(Force f)
        {
            return new ColumnLoad(f);
        }
    }
}
