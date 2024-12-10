using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class CircularHollow : ICircularHollow
    {
        public Length Diameter { get; set; }
        public Length Thickness { get; set; }
        public string Description
            => $"Ø{Utility.Description.Create(Diameter, Thickness)}";

        public CircularHollow(Length diameter, Length thickness)
        {
            Diameter = diameter;
            Thickness = thickness;
        }
    }
}
