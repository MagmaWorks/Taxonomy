namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC6x12 : SingletonAmericanBase<MC6x12>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC6X12";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.495, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.248, LengthUnit.Inch);
        public Length WebHeight => new Length(4.25, LengthUnit.Inch);

        public MC6x12() { }
    }
}
