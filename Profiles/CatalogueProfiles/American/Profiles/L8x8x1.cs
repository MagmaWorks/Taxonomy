namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x8x1 : SingletonAmericanBase<L8x8x1>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X8X1";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.63, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.315, LengthUnit.Inch);

        public L8x8x1() { }
    }
}
