namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe1_1over4SCH80 : SingletonAmericanBase<Pipe1_1over4SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe1-1/4SCH80";
        public Length Diameter => new Length(1.66, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public Pipe1_1over4SCH80() { }
    }
}
