namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x34 : SingletonAmericanBase<WT10_5x34>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X34";
        public Length Height => new Length(10.60, LengthUnit.Inch);
        public Length Width => new Length(8.27, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.41, LengthUnit.Inch);

        public WT10_5x34() { }
    }
}
