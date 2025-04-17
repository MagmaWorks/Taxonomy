namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x326 : SingletonAmericanBase<WT18x326>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X326";
        public Length Height => new Length(20.50, LengthUnit.Inch);
        public Length Width => new Length(17.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.54, LengthUnit.Inch);
        public Length WebThickness => new Length(1.97, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.01, LengthUnit.Inch);

        public WT18x326() { }
    }
}
