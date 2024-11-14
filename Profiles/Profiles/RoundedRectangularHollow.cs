using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class RoundedRectangularHollow : IRoundedRectangularHollow
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length FlatHeight { get; set; }
        public Length FlatWidth { get; set; }
        public Length Thickness { get; set; }

        public RoundedRectangularHollow(Length width, Length height, Length flatWidth, Length flatHeight, Length thickness)
        {
            Height = height;
            Width = width;
            FlatHeight = flatHeight;
            FlatWidth = flatWidth;
            Thickness = thickness;
        }
    }
}
