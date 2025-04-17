namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x60 : SingletonAmericanBase<WT6x60>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X60";
        public Length Height => new Length(6.56, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.11, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x60() { }
    }
}
