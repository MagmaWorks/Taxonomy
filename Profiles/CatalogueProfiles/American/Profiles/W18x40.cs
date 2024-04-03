using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x40 : SingletonAmericanBase<W18x40>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X40";
        public Length Height => new Length(17.90, LengthUnit.Inch);
        public Length Width => new Length(6.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.53, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.65, LengthUnit.Inch);

        public W18x40() { }
    }
}
