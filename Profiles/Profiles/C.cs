using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class C : IC
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length WebThickness { get; set; }
        public Length FlangeThickness { get; set; }
        public Length Lip { get; set; }
        public string Description
            => Utility.Describe(Height, Width, WebThickness, FlangeThickness, Lip);

        public C(Length height, Length width, Length webThickness, Length flangeThickness, Length lip)
        {
            Height = height;
            Width = width;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            Lip = lip;
        }
    }
}
