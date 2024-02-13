using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Tee : ITee
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length FlangeThickness { get; set; }
        public Length WebThickness { get; set; }

        public Tee(Length height, Length width, Length flangeThickness, Length webThickness)
        {
            Height = height;
            Width = width;
            FlangeThickness = flangeThickness;
            WebThickness = webThickness;
        }
    }
}
