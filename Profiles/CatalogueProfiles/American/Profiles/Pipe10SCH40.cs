namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe10SCH40 : SingletonAmericanBase<Pipe10SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe10SCH40";
        public Length Diameter => new Length(10.75, LengthUnit.Inch);
        public Length Thickness => new Length(0.37, LengthUnit.Inch);

        public Pipe10SCH40() { }
    }
}
