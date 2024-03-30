using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x283 : SingletonAmericanBase<W18x283>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X283";
        public Length Height => new Length(21.90, LengthUnit.Inch);
        public Length Width => new Length(11.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.50, LengthUnit.Inch);
        public Length WebThickness => new Length(1.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.885, LengthUnit.Inch);

        public W18x283() { }
    }
}
