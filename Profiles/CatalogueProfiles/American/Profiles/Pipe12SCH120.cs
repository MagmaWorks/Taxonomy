namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe12SCH120 : SingletonAmericanBase<Pipe12SCH120>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe12SCH120";
        public Length Diameter => new Length(12.75, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public Pipe12SCH120() { }
    }
}
