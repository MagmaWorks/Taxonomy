namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x171 : SingletonAmericanBase<WT7x171>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X171";
        public Length Height => new Length(8.77, LengthUnit.Inch);
        public Length Width => new Length(16.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.47, LengthUnit.Inch);
        public Length WebThickness => new Length(1.54, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x171() { }
    }
}
