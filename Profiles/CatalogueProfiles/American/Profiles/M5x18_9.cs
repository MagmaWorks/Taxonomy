namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M5x18_9 : SingletonAmericanBase<M5x18_9>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M5X18.9";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.39, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.234, LengthUnit.Inch);
        public Length WebHeight => new Length(3.38, LengthUnit.Inch);

        public M5x18_9() { }
    }
}
