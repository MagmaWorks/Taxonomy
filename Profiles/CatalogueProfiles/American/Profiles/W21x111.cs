namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x111 : SingletonAmericanBase<W21x111>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X111";
        public Length Height => new Length(21.50, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.225, LengthUnit.Inch);

        public W21x111() { }
    }
}
