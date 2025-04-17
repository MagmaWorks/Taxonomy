namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC12x50 : SingletonAmericanBase<MC12x50>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC12X50";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(4.14, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.70, LengthUnit.Inch);
        public Length WebThickness => new Length(0.84, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.61, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.305, LengthUnit.Inch);
        public Length WebHeight => new Length(9.38, LengthUnit.Inch);

        public MC12x50() { }
    }
}
