using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class EllipseHollow : IEllipseHollow
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length Thickness { get; set; }

        public EllipseHollow(Length height, Length width, Length thickness)
        {
            Height = height;
            Width = width;
            Thickness = thickness;
        }
    }
}
