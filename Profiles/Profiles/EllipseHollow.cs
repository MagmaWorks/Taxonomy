using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class EllipseHollow : IEllipseHollow
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length Thickness { get; set; }
        public string Description => Utility.Description.Create(Height, Width, Thickness);

        public EllipseHollow(Length width, Length height, Length thickness)
        {
            Height = height;
            Width = width;
            Thickness = thickness;
        }
    }
}
