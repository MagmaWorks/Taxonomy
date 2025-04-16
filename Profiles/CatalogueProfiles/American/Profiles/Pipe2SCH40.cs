namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe2SCH40 : SingletonAmericanBase<Pipe2SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe2SCH40";
        public Length Diameter => new Length(2.38, LengthUnit.Inch);
        public Length Thickness => new Length(0.15, LengthUnit.Inch);

        public Pipe2SCH40() { }
    }
}
