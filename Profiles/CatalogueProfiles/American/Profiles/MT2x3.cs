namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT2x3 : SingletonAmericanBase<MT2x3>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT2X3";
        public Length Height => new Length(1.90, LengthUnit.Inch);
        public Length Width => new Length(3.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.16, LengthUnit.Inch);
        public Length WebThickness => new Length(0.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.4, LengthUnit.Inch);

        public MT2x3() { }
    }
}
