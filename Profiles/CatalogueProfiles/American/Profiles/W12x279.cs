using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x279 : SingletonAmericanBase<W12x279>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X279";
        public Length Height => new Length(15.90, LengthUnit.Inch);
        public Length Width => new Length(13.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.47, LengthUnit.Inch);
        public Length WebThickness => new Length(1.53, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.865, LengthUnit.Inch);

        public W12x279() { }
    }
}
