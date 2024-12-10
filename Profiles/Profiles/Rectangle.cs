using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Rectangle : IRectangle
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public string Description => Utility.Describe(Width, Height);

        public Rectangle(Length width, Length height)
        {
            Height = height;
            Width = width;
        }
    }
}
