namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe14xS : SingletonAmericanBase<Pipe14xS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe14XS";
        public Length Diameter => new Length(14.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe14xS() { }
    }
}
