namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x16_5 : SingletonAmericanBase<WT5x16_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X16.5";
        public Length Height => new Length(4.87, LengthUnit.Inch);
        public Length Width => new Length(7.96, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.93, LengthUnit.Inch);

        public WT5x16_5() { }
    }
}
