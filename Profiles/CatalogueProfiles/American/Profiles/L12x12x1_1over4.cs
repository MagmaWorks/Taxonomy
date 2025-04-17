namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L12x12x1_1over4 : SingletonAmericanBase<L12x12x1_1over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L12X12X1-1/4";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(1.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.71, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.355, LengthUnit.Inch);

        public L12x12x1_1over4() { }
    }
}
