namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe1SCH80 : SingletonAmericanBase<Pipe1SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe1SCH80";
        public Length Diameter => new Length(1.32, LengthUnit.Inch);
        public Length Thickness => new Length(0.18, LengthUnit.Inch);

        public Pipe1SCH80() { }
    }
}
