namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC13x50 : SingletonAmericanBase<MC13x50>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC13X50";
        public Length Height => new Length(13.00, LengthUnit.Inch);
        public Length Width => new Length(4.41, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.79, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.825, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.412, LengthUnit.Inch);
        public Length WebHeight => new Length(10.13, LengthUnit.Inch);

        public MC13x50() { }
    }
}
