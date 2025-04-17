namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x29 : SingletonAmericanBase<WT6x29>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X29";
        public Length Height => new Length(6.10, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.64, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x29() { }
    }
}
