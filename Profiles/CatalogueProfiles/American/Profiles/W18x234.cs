using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x234 : SingletonAmericanBase<W18x234>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X234";
        public Length Height => new Length(21.10, LengthUnit.Inch);
        public Length Width => new Length(11.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.11, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.875, LengthUnit.Inch);

        public W18x234() { }
    }
}
