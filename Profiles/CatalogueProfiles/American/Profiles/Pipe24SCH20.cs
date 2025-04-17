namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe24SCH20 : SingletonAmericanBase<Pipe24SCH20>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe24SCH20";
        public Length Diameter => new Length(24.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public Pipe24SCH20() { }
    }
}
