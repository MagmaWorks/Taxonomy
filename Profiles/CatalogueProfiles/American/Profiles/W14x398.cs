namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x398 : SingletonAmericanBase<W14x398>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X398";
        public Length Height => new Length(18.30, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.85, LengthUnit.Inch);
        public Length WebThickness => new Length(1.77, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.245, LengthUnit.Inch);

        public W14x398() { }
    }
}
