namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x141_5 : SingletonAmericanBase<WT9x141_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X141.5";
        public Length Height => new Length(10.90, LengthUnit.Inch);
        public Length Width => new Length(11.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.50, LengthUnit.Inch);
        public Length WebThickness => new Length(1.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.9, LengthUnit.Inch);

        public WT9x141_5() { }
    }
}
