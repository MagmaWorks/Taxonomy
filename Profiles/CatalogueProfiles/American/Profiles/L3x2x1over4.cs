namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L3x2x1over4 : SingletonAmericanBase<L3x2x1over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L3X2X1/4";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.31, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.155, LengthUnit.Inch);

        public L3x2x1over4() { }
    }
}
