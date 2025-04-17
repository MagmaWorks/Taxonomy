namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe1_1over2SCH40 : SingletonAmericanBase<Pipe1_1over2SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe1-1/2SCH40";
        public Length Diameter => new Length(1.90, LengthUnit.Inch);
        public Length Thickness => new Length(0.15, LengthUnit.Inch);

        public Pipe1_1over2SCH40() { }
    }
}
