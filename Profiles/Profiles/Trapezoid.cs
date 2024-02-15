using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Trapezoid : ITrapezoid
    {
        public Length Height { get; set; }
        public Length TopWidth { get; set; }
        public Length BottomWidth { get; set; }

        public Trapezoid(Length height, Length topWidth, Length bottomWidth)
        {
            Height = height;
            TopWidth = topWidth;
            BottomWidth = bottomWidth;
        }
    }
}
