using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Channel : IChannel
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length WebThickness { get; set; }
        public Length FlangeThickness { get; set; }
        public string Description
            => Utility.Description.Create(Height, Width, WebThickness, FlangeThickness);

        public Channel(Length height, Length width, Length webThickness, Length flangeThickness)
        {
            Height = height;
            Width = width;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
        }
    }
}
