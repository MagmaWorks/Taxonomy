using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Angle : IAngle
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length WebThickness { get; set; }
        public Length FlangeThickness { get; set; }
        public string Description
            => Utility.Description.Create(Height, Width, WebThickness, FlangeThickness);

        public Angle(Length height, Length width, Length webThickness, Length flangeThickness)
        {
            Height = height;
            Width = width;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
        }
    }
}
