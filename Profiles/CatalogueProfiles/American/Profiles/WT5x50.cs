namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x50 : SingletonAmericanBase<WT5x50>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X50";
        public Length Height => new Length(5.55, LengthUnit.Inch);
        public Length Width => new Length(10.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.12, LengthUnit.Inch);
        public Length WebThickness => new Length(0.68, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.93, LengthUnit.Inch);

        public WT5x50() { }
    }
}
