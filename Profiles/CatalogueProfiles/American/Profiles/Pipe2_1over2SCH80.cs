namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe2_1over2SCH80 : SingletonAmericanBase<Pipe2_1over2SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe2-1/2SCH80";
        public Length Diameter => new Length(2.88, LengthUnit.Inch);
        public Length Thickness => new Length(0.28, LengthUnit.Inch);

        public Pipe2_1over2SCH80() { }
    }
}
