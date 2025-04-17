namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe10SCH140 : SingletonAmericanBase<Pipe10SCH140>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe10SCH140";
        public Length Diameter => new Length(10.75, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public Pipe10SCH140() { }
    }
}
