namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L10x10x1_1over8 : SingletonAmericanBase<L10x10x1_1over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L10X10X1-1/8";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.8, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.4, LengthUnit.Inch);

        public L10x10x1_1over8() { }
    }
}
