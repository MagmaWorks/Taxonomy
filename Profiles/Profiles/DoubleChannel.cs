using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class DoubleChannel : IDoubleChannel
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length WebThickness { get; set; }
        public Length FlangeThickness { get; set; }
        public Length BackToBackDistance { get; set; }
        public string Description
            => $"{Utility.Description.Create(Height, Width, WebThickness, FlangeThickness)} B2B{BackToBackDistance}";

        public DoubleChannel(Length height, Length width, Length webThickness, Length flangeThickness, Length backToBackDistance)
        {
            Height = height;
            Width = width;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            BackToBackDistance = backToBackDistance;
        }
    }
}
