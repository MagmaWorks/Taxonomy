namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC12x31 : SingletonAmericanBase<MC12x31>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC12X31";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.67, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.70, LengthUnit.Inch);
        public Length WebThickness => new Length(0.37, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.61, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.305, LengthUnit.Inch);
        public Length WebHeight => new Length(9.38, LengthUnit.Inch);

        public MC12x31() { }
    }
}
