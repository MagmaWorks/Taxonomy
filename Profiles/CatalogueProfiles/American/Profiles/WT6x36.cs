namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x36 : SingletonAmericanBase<WT6x36>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X36";
        public Length Height => new Length(6.13, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.67, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x36() { }
    }
}
