namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x59_5 : SingletonAmericanBase<WT9x59_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X59.5";
        public Length Height => new Length(9.49, LengthUnit.Inch);
        public Length Width => new Length(11.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.06, LengthUnit.Inch);
        public Length WebThickness => new Length(0.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x59_5() { }
    }
}
