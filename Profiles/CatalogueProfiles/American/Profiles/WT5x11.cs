namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x11 : SingletonAmericanBase<WT5x11>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X11";
        public Length Height => new Length(5.09, LengthUnit.Inch);
        public Length Width => new Length(5.75, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.43, LengthUnit.Inch);

        public WT5x11() { }
    }
}
