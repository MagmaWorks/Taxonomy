using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PointMoment2d : IPointMoment2d
    {
        public Moment Yy { get; set; } = Moment.Zero;
        public Moment Zz { get; set; } = Moment.Zero;

        internal PointMoment2d() { }

        public PointMoment2d(Moment yy, Moment zz)
        {
            Yy = yy;
            Zz = zz;
        }
    }
}
