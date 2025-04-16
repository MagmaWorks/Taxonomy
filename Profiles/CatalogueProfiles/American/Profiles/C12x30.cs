namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C12x30 : SingletonAmericanBase<C12x30>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C12X30";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.17, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.51, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.625, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.312, LengthUnit.Inch);
        public Length WebHeight => new Length(9.75, LengthUnit.Inch);

        public C12x30() { }
    }
}
