namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x60 : SingletonAmericanBase<WT7x60>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X60";
        public Length Height => new Length(7.24, LengthUnit.Inch);
        public Length Width => new Length(14.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.94, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x60() { }
    }
}
