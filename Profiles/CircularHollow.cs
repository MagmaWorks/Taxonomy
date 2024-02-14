using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class CircularHollow : ICircularHollow
    {
        public Length Diameter { get; set; }

        public Length Thickness { get; set; }

        public CircularHollow(Length diameter, Length thickness)
        {
            Diameter = diameter;
            Thickness = thickness;
        }
    }
}
