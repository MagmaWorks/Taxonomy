namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe26SCH20 : SingletonAmericanBase<Pipe26SCH20>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe26SCH20";
        public Length Diameter => new Length(26.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe26SCH20() { }
    }
}
