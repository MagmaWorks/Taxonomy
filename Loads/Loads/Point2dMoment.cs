using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Point2dMoment : IPoint2dMoment
    {
        public Moment Yy { get; set; } = Moment.Zero;
        public Moment Zz { get; set; } = Moment.Zero;

        internal Point2dMoment() { }

        public Point2dMoment(Moment yy, Moment zz)
        {
            Yy = yy;
            Zz = zz;
        }
    }
}
