namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC12x45 : SingletonAmericanBase<MC12x45>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC12X45";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(4.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.70, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.61, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.305, LengthUnit.Inch);
        public Length WebHeight => new Length(9.38, LengthUnit.Inch);

        public MC12x45() { }
    }
}
