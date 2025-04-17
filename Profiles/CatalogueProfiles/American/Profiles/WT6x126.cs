namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x126 : SingletonAmericanBase<WT6x126>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X126";
        public Length Height => new Length(7.71, LengthUnit.Inch);
        public Length Width => new Length(13.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.25, LengthUnit.Inch);
        public Length WebThickness => new Length(1.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x126() { }
    }
}
