namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe2xxS : SingletonAmericanBase<Pipe2xxS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe2XXS";
        public Length Diameter => new Length(2.38, LengthUnit.Inch);
        public Length Thickness => new Length(0.44, LengthUnit.Inch);

        public Pipe2xxS() { }
    }
}
