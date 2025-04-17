namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x147 : SingletonAmericanBase<W21x147>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X147";
        public Length Height => new Length(22.10, LengthUnit.Inch);
        public Length Width => new Length(12.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.15, LengthUnit.Inch);
        public Length WebThickness => new Length(0.72, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W21x147() { }
    }
}
