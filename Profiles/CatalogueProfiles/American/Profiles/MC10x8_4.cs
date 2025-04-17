namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC10x8_4 : SingletonAmericanBase<MC10x8_4>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC10X8.4";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.28, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.47, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.235, LengthUnit.Inch);
        public Length WebHeight => new Length(8.50, LengthUnit.Inch);

        public MC10x8_4() { }
    }
}
