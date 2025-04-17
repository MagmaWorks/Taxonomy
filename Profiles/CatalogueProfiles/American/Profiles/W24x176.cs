namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x176 : SingletonAmericanBase<W24x176>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X176";
        public Length Height => new Length(25.20, LengthUnit.Inch);
        public Length Width => new Length(12.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.34, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.185, LengthUnit.Inch);

        public W24x176() { }
    }
}
