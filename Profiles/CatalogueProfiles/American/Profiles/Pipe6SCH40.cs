namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe6SCH40 : SingletonAmericanBase<Pipe6SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe6SCH40";
        public Length Diameter => new Length(6.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.28, LengthUnit.Inch);

        public Pipe6SCH40() { }
    }
}
