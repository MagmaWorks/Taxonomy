namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x152_5 : SingletonAmericanBase<WT6x152_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X152.5";
        public Length Height => new Length(8.16, LengthUnit.Inch);
        public Length Width => new Length(13.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.71, LengthUnit.Inch);
        public Length WebThickness => new Length(1.63, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x152_5() { }
    }
}
