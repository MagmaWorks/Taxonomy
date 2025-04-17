namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT3x4_25 : SingletonAmericanBase<WT3x4_25>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT3X4.25";
        public Length Height => new Length(2.92, LengthUnit.Inch);
        public Length Width => new Length(3.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.20, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.47, LengthUnit.Inch);

        public WT3x4_25() { }
    }
}
