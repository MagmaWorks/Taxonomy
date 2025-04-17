namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L3x3x3over16 : SingletonAmericanBase<L3x3x3over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L3X3X3/16";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.37, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.185, LengthUnit.Inch);

        public L3x3x3over16() { }
    }
}
