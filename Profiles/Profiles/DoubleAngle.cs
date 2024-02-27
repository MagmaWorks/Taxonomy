using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class DoubleAngle : IDoubleAngle
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length WebThickness { get; set; }
        public Length FlangeThickness { get; set; }
        public Length BackToBackDistance { get; set; }

        public DoubleAngle(Length height, Length width, Length webThickness, Length flangeThickness, Length backToBackDistance)
        {
            Height = height;
            Width = width;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            BackToBackDistance = backToBackDistance;
        }
    }
}
