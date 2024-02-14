using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Rectangle : IRectangle
    {
        public Length Height { get; set; }
        public Length Width { get; set; }

        public Rectangle(Length height, Length width)
        {
            Height = height;
            Width = width;
        }
    }
}
