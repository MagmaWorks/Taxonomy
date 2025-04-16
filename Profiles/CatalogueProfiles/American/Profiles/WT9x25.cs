namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x25 : SingletonAmericanBase<WT9x25>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X25";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(7.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x25() { }
    }
}
