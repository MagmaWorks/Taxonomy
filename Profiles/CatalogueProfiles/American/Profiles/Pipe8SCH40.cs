namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe8SCH40 : SingletonAmericanBase<Pipe8SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe8SCH40";
        public Length Diameter => new Length(8.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.32, LengthUnit.Inch);

        public Pipe8SCH40() { }
    }
}
