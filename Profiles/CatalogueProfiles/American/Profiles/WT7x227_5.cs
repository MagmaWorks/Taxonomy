namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x227_5 : SingletonAmericanBase<WT7x227_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X227.5";
        public Length Height => new Length(9.51, LengthUnit.Inch);
        public Length Width => new Length(16.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.21, LengthUnit.Inch);
        public Length WebThickness => new Length(2.02, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x227_5() { }
    }
}
