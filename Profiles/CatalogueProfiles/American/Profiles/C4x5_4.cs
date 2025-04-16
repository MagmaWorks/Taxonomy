namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C4x5_4 : SingletonAmericanBase<C4x5_4>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C4X5.4";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(1.58, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.30, LengthUnit.Inch);
        public Length WebThickness => new Length(0.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.45, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.225, LengthUnit.Inch);
        public Length WebHeight => new Length(2.50, LengthUnit.Inch);

        public C4x5_4() { }
    }
}
