namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x8x9over16 : SingletonAmericanBase<L8x8x9over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X8X9/16";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.56, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.63, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.315, LengthUnit.Inch);

        public L8x8x9over16() { }
    }
}
