using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x264 : SingletonAmericanBase<W40x264>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X264";
        public Length Height => new Length(40.00, LengthUnit.Inch);
        public Length Width => new Length(11.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.73, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.27, LengthUnit.Inch);

        public W40x264() { }
    }
}
