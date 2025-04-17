namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x120 : SingletonAmericanBase<W14x120>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X120";
        public Length Height => new Length(14.50, LengthUnit.Inch);
        public Length Width => new Length(14.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.94, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.205, LengthUnit.Inch);

        public W14x120() { }
    }
}
