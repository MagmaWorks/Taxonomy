using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x235 : SingletonAmericanBase<W40x235>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X235";
        public Length Height => new Length(39.70, LengthUnit.Inch);
        public Length Width => new Length(11.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W40x235() { }
    }
}
