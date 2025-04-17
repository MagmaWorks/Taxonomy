namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe1SCH40 : SingletonAmericanBase<Pipe1SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe1SCH40";
        public Length Diameter => new Length(1.32, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public Pipe1SCH40() { }
    }
}
