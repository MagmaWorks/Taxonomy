namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe3over4SCH80 : SingletonAmericanBase<Pipe3over4SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe3/4SCH80";
        public Length Diameter => new Length(1.05, LengthUnit.Inch);
        public Length Thickness => new Length(0.15, LengthUnit.Inch);

        public Pipe3over4SCH80() { }
    }
}
