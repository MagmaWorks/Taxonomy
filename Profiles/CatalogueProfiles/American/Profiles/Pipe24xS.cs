namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe24xS : SingletonAmericanBase<Pipe24xS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe24XS";
        public Length Diameter => new Length(24.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe24xS() { }
    }
}
