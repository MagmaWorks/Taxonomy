namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe6xxS : SingletonAmericanBase<Pipe6xxS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe6XXS";
        public Length Diameter => new Length(6.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.86, LengthUnit.Inch);

        public Pipe6xxS() { }
    }
}
