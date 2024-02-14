using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Ellipse : IEllipse
    {
        public Length Height { get; set; }
        public Length Width { get; set; }

        public Ellipse(Length height, Length width)
        {
            Height = height;
            Width = width;
        }
    }
}
