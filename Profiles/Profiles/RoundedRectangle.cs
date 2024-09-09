using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class RoundedRectangle : IRoundedRectangle
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length FlatHeight { get; set; }
        public Length FlatWidth { get; set; }

        public RoundedRectangle(Length height, Length width, Length flatHeight, Length flatWidth)
        {
            Height = height;
            Width = width;
            FlatHeight = flatHeight;
            FlatWidth = flatWidth;
        }
    }
}
