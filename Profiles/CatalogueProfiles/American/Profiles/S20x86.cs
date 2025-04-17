namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S20x86 : SingletonAmericanBase<S20x86>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S20X86";
        public Length Height => new Length(20.30, LengthUnit.Inch);
        public Length Width => new Length(7.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.92, LengthUnit.Inch);
        public Length WebThickness => new Length(0.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.855, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.513, LengthUnit.Inch);
        public Length WebHeight => new Length(16.75, LengthUnit.Inch);

        public S20x86() { }
    }
}
