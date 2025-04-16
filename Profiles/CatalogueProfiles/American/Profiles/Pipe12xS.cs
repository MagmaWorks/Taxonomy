namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe12xS : SingletonAmericanBase<Pipe12xS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe12XS";
        public Length Diameter => new Length(12.75, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe12xS() { }
    }
}
