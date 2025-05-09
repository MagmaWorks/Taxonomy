﻿namespace MagmaWorks.Taxonomy.Profiles
{
    public class Cruciform : ICruciform
    {
        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length FlangeThickness { get; set; }
        public Length WebThickness { get; set; }
        public string Description
            => Utility.Describe(Height, Width, FlangeThickness, WebThickness);

        public Cruciform(Length height, Length width, Length flangeThickness, Length webThickness)
        {
            Height = height;
            Width = width;
            FlangeThickness = flangeThickness;
            WebThickness = webThickness;
        }
    }
}
