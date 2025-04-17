namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC6x15_1 : SingletonAmericanBase<MC6x15_1>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC6X15.1";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(2.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.48, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.58, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.29, LengthUnit.Inch);
        public Length WebHeight => new Length(3.88, LengthUnit.Inch);

        public MC6x15_1() { }
    }
}
