namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT3x8 : SingletonAmericanBase<WT3x8>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT3X8";
        public Length Height => new Length(3.14, LengthUnit.Inch);
        public Length Width => new Length(4.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.41, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.48, LengthUnit.Inch);

        public WT3x8() { }
    }
}
