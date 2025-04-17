namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C3x6 : SingletonAmericanBase<C3x6>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C3X6";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(1.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.27, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.415, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.208, LengthUnit.Inch);
        public Length WebHeight => new Length(1.63, LengthUnit.Inch);

        public C3x6() { }
    }
}
