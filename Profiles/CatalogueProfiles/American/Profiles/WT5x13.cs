namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x13 : SingletonAmericanBase<WT5x13>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X13";
        public Length Height => new Length(5.17, LengthUnit.Inch);
        public Length Width => new Length(5.77, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.43, LengthUnit.Inch);

        public WT5x13() { }
    }
}
