namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC8x18_7 : SingletonAmericanBase<MC8x18_7>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC8X18.7";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(2.98, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.625, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.312, LengthUnit.Inch);
        public Length WebHeight => new Length(5.75, LengthUnit.Inch);

        public MC8x18_7() { }
    }
}
