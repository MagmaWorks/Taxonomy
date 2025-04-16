namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C3x5 : SingletonAmericanBase<C3x5>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C3X5";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.27, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.415, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.208, LengthUnit.Inch);
        public Length WebHeight => new Length(1.63, LengthUnit.Inch);

        public C3x5() { }
    }
}
