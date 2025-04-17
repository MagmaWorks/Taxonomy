namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x148_5 : SingletonAmericanBase<WT20x148_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X148.5";
        public Length Height => new Length(19.90, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.93, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.07, LengthUnit.Inch);

        public WT20x148_5() { }
    }
}
