using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class ICustom : IICustom
    {
        public Length Height { get; set; }
        public Length TopFlangeWidth { get; set; }
        public Length BottomFlangeWidth { get; set; }
        public Length TopFlangeThickness { get; set; }
        public Length BottomFlangeThickness { get; set; }
        public Length WebThickness { get; set; }

        public ICustom(Length height, Length topFlangeWidth, Length bottomFlangeWidth, Length topFlangeThickness, Length bottomFlangeThickness, Length webThickness)
        {
            Height = height;
            TopFlangeWidth = topFlangeWidth;
            BottomFlangeWidth = bottomFlangeWidth;
            TopFlangeThickness = topFlangeThickness;
            BottomFlangeThickness = bottomFlangeThickness;
            WebThickness = webThickness;
        }
    }
}
