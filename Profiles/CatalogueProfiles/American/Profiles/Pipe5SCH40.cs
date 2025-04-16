namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe5SCH40 : SingletonAmericanBase<Pipe5SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe5SCH40";
        public Length Diameter => new Length(5.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.26, LengthUnit.Inch);

        public Pipe5SCH40() { }
    }
}
