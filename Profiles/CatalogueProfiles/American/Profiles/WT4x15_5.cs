namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x15_5 : SingletonAmericanBase<WT4x15_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X15.5";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.17, LengthUnit.Inch);

        public WT4x15_5() { }
    }
}
