namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L4x3_1over2x3over8 : SingletonAmericanBase<L4x3_1over2x3over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L4X3-1/2X3/8";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.37, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.185, LengthUnit.Inch);

        public L4x3_1over2x3over8() { }
    }
}
