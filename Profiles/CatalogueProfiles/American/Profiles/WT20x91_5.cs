namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x91_5 : SingletonAmericanBase<WT20x91_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X91.5";
        public Length Height => new Length(19.50, LengthUnit.Inch);
        public Length Width => new Length(11.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.20, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.12, LengthUnit.Inch);

        public WT20x91_5() { }
    }
}
