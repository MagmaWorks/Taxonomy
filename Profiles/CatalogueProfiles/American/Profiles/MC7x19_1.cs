namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC7x19_1 : SingletonAmericanBase<MC7x19_1>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC7X19.1";
        public Length Height => new Length(7.00, LengthUnit.Inch);
        public Length Width => new Length(3.45, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.625, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.312, LengthUnit.Inch);
        public Length WebHeight => new Length(4.75, LengthUnit.Inch);

        public MC7x19_1() { }
    }
}
