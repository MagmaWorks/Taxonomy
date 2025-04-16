namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe8SCH80 : SingletonAmericanBase<Pipe8SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe8SCH80";
        public Length Diameter => new Length(8.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe8SCH80() { }
    }
}
