namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC12x10_6 : SingletonAmericanBase<MC12x10_6>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC12X10.6";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.44, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.22, LengthUnit.Inch);
        public Length WebHeight => new Length(10.50, LengthUnit.Inch);

        public MC12x10_6() { }
    }
}
