namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT3x12_5 : SingletonAmericanBase<WT3x12_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT3X12.5";
        public Length Height => new Length(3.19, LengthUnit.Inch);
        public Length Width => new Length(6.08, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.46, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.48, LengthUnit.Inch);

        public WT3x12_5() { }
    }
}
