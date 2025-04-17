namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe16SCH40 : SingletonAmericanBase<Pipe16SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe16SCH40";
        public Length Diameter => new Length(16.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe16SCH40() { }
    }
}
