namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x104 : SingletonAmericanBase<W24x104>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X104";
        public Length Height => new Length(24.10, LengthUnit.Inch);
        public Length Width => new Length(12.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public W24x104() { }
    }
}
