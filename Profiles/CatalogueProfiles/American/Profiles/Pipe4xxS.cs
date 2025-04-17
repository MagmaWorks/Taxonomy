namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe4xxS : SingletonAmericanBase<Pipe4xxS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe4XXS";
        public Length Diameter => new Length(4.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.67, LengthUnit.Inch);

        public Pipe4xxS() { }
    }
}
