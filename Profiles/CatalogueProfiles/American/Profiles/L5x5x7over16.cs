namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L5x5x7over16 : SingletonAmericanBase<L5x5x7over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L5X5X7/16";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.25, LengthUnit.Inch);

        public L5x5x7over16() { }
    }
}
