namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C12x20_7 : SingletonAmericanBase<C12x20_7>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C12X20.7";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(2.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.28, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.625, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.312, LengthUnit.Inch);
        public Length WebHeight => new Length(9.75, LengthUnit.Inch);

        public C12x20_7() { }
    }
}
