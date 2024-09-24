using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PointMoment : Point2dMoment, IPointMoment
    {
        public Moment Xx { get; set; } = Moment.Zero;

        public PointMoment(Moment xx, Moment yy, Moment zz)
        {
            Xx = xx;
            Yy = yy;
            Zz = zz;
        }
    }
}
