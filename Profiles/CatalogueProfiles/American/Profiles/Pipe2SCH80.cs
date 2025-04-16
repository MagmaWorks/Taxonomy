namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe2SCH80 : SingletonAmericanBase<Pipe2SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe2SCH80";
        public Length Diameter => new Length(2.38, LengthUnit.Inch);
        public Length Thickness => new Length(0.22, LengthUnit.Inch);

        public Pipe2SCH80() { }
    }
}
