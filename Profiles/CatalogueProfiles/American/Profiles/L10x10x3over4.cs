namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L10x10x3over4 : SingletonAmericanBase<L10x10x3over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L10X10X3/4";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.8, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.4, LengthUnit.Inch);

        public L10x10x3over4() { }
    }
}
