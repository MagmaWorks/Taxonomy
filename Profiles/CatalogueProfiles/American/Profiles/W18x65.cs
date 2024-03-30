using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x65 : SingletonAmericanBase<W18x65>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X65";
        public Length Height => new Length(18.40, LengthUnit.Inch);
        public Length Width => new Length(7.59, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.45, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.7, LengthUnit.Inch);

        public W18x65() { }
    }
}
