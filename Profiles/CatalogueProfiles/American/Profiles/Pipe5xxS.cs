namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe5xxS : SingletonAmericanBase<Pipe5xxS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe5XXS";
        public Length Diameter => new Length(5.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public Pipe5xxS() { }
    }
}
