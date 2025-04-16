namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x105_5 : SingletonAmericanBase<WT9x105_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X105.5";
        public Length Height => new Length(10.30, LengthUnit.Inch);
        public Length Width => new Length(11.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.91, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.99, LengthUnit.Inch);

        public WT9x105_5() { }
    }
}
