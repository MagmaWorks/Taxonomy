namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC6x15_3 : SingletonAmericanBase<MC6x15_3>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC6X15.3";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.39, LengthUnit.Inch);
        public Length WebThickness => new Length(0.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.485, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.242, LengthUnit.Inch);
        public Length WebHeight => new Length(4.25, LengthUnit.Inch);

        public MC6x15_3() { }
    }
}
