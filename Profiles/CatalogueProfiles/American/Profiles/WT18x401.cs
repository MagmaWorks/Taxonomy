namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x401 : SingletonAmericanBase<WT18x401>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X401";
        public Length Height => new Length(21.30, LengthUnit.Inch);
        public Length Width => new Length(18.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.29, LengthUnit.Inch);
        public Length WebThickness => new Length(2.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.26, LengthUnit.Inch);

        public WT18x401() { }
    }
}
