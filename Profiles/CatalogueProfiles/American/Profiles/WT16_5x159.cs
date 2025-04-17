namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x159 : SingletonAmericanBase<WT16_5x159>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X159";
        public Length Height => new Length(17.60, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.89, LengthUnit.Inch);
        public Length WebThickness => new Length(1.04, LengthUnit.Inch);
        public Length FilletRadius => new Length(14.92, LengthUnit.Inch);

        public WT16_5x159() { }
    }
}
