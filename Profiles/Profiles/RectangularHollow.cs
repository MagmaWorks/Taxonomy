using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class RectangularHollow : IRectangularHollow
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length Thickness { get; set; }

        public RectangularHollow(Length width, Length height, Length thickness)
        {
            Height = height;
            Width = width;
            Thickness = thickness;
        }
    }
}
