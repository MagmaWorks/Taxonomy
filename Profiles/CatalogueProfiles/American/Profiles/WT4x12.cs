namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x12 : SingletonAmericanBase<WT4x12>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X12";
        public Length Height => new Length(3.97, LengthUnit.Inch);
        public Length Width => new Length(6.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.18, LengthUnit.Inch);

        public WT4x12() { }
    }
}
