using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x431 : SingletonAmericanBase<W40x431>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X431";
        public Length Height => new Length(41.30, LengthUnit.Inch);
        public Length Width => new Length(16.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.36, LengthUnit.Inch);
        public Length WebThickness => new Length(1.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.21, LengthUnit.Inch);

        public W40x431() { }
    }
}
