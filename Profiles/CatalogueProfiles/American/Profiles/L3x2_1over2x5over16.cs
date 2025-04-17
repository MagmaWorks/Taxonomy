namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L3x2_1over2x5over16 : SingletonAmericanBase<L3x2_1over2x5over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L3X2-1/2X5/16";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.38, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.19, LengthUnit.Inch);

        public L3x2_1over2x5over16() { }
    }
}
