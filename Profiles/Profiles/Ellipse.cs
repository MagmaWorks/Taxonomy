using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Ellipse : IEllipse
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public string Description => Utility.Description.Create(Height, Width);

        public Ellipse(Length width, Length height)
        {
            Height = height;
            Width = width;
        }
    }
}
