namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x258 : SingletonAmericanBase<W27x258>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X258";
        public Length Height => new Length(29.00, LengthUnit.Inch);
        public Length Width => new Length(14.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.77, LengthUnit.Inch);
        public Length WebThickness => new Length(0.98, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W27x258() { }
    }
}
