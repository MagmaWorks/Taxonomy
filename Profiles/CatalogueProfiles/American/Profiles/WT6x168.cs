namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x168 : SingletonAmericanBase<WT6x168>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X168";
        public Length Height => new Length(8.41, LengthUnit.Inch);
        public Length Width => new Length(13.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.96, LengthUnit.Inch);
        public Length WebThickness => new Length(1.78, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x168() { }
    }
}
