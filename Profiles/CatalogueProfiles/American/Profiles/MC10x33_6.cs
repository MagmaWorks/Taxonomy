namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC10x33_6 : SingletonAmericanBase<MC10x33_6>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC10X33.6";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(4.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.58, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.73, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.365, LengthUnit.Inch);
        public Length WebHeight => new Length(7.38, LengthUnit.Inch);

        public MC10x33_6() { }
    }
}
