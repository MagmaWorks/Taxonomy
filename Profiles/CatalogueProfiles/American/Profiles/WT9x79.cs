namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x79 : SingletonAmericanBase<WT9x79>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X79";
        public Length Height => new Length(9.86, LengthUnit.Inch);
        public Length Width => new Length(11.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.81, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.02, LengthUnit.Inch);

        public WT9x79() { }
    }
}
