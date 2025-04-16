namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x124_5 : SingletonAmericanBase<WT20x124_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X124.5";
        public Length Height => new Length(19.70, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.1, LengthUnit.Inch);

        public WT20x124_5() { }
    }
}
