using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Trapezoid : ITrapezoid
    {
        public Length Height { get; set; }
        public Length TopWidth { get; set; }
        public Length BottomWidth { get; set; }
        public string Description => GetDescription();

        public Trapezoid(Length topWidth, Length bottomWidth, Length height)
        {
            Height = height;
            TopWidth = topWidth;
            BottomWidth = bottomWidth;
        }

        private string GetDescription()
        {
            LengthUnit u = Height.Unit;
            string topAndBottom = Utility.Description.Create("/", TopWidth.ToUnit(u), BottomWidth);
            string height = Utility.Description.Create(Height);
            return $"{topAndBottom}x{height}";
        }
    }
}
