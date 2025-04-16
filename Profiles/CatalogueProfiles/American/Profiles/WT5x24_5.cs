namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x24_5 : SingletonAmericanBase<WT5x24_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X24.5";
        public Length Height => new Length(4.99, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.93, LengthUnit.Inch);

        public WT5x24_5() { }
    }
}
