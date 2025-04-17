namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x251_5 : SingletonAmericanBase<WT20x251_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X251.5";
        public Length Height => new Length(21.00, LengthUnit.Inch);
        public Length Width => new Length(16.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.76, LengthUnit.Inch);
        public Length WebThickness => new Length(1.54, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.06, LengthUnit.Inch);

        public WT20x251_5() { }
    }
}
