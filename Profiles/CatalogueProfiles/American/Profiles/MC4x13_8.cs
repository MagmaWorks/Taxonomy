namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC4x13_8 : SingletonAmericanBase<MC4x13_8>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC4X13.8";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.25, LengthUnit.Inch);
        public Length WebHeight => new Length(2.00, LengthUnit.Inch);

        public MC4x13_8() { }
    }
}
