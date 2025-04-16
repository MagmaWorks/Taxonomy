namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe20SCH30 : SingletonAmericanBase<Pipe20SCH30>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe20SCH30";
        public Length Diameter => new Length(20.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe20SCH30() { }
    }
}
