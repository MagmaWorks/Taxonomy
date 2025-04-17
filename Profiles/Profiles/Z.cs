namespace MagmaWorks.Taxonomy.Profiles
{
    public class Z : IZ
    {
        public Length Height { get; set; }
        public Length TopFlangeWidth { get; set; }
        public Length BottomFlangeWidth { get; set; }
        public Length Thickness { get; set; }
        public Length TopLip { get; set; }
        public Length BottomLip { get; set; }
        public string Description => Utility.Describe(
                Height, TopFlangeWidth, BottomFlangeWidth, Thickness, TopLip, BottomLip);

        public Z(Length height, Length topFlangeWidth, Length bottomFlangeWidth, Length thickness, Length topLip, Length bottomLip)
        {
            Height = height;
            TopFlangeWidth = topFlangeWidth;
            BottomFlangeWidth = bottomFlangeWidth;
            Thickness = thickness;
            TopLip = topLip;
            BottomLip = bottomLip;
        }
    }
}
