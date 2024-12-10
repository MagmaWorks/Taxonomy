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
            string topAndBottom = Utility.Describe("/", TopWidth.ToUnit(u), BottomWidth);
            topAndBottom = topAndBottom.Replace(Length.GetAbbreviation(u), string.Empty);
            string height = Utility.Describe(Height);
            return $"{topAndBottom}×{height}";
        }
    }
}
