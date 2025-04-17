namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC6x6_5 : SingletonAmericanBase<MC6x6_5>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC6X6.5";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(1.85, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.29, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.46, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.23, LengthUnit.Inch);
        public Length WebHeight => new Length(4.50, LengthUnit.Inch);

        public MC6x6_5() { }
    }
}
