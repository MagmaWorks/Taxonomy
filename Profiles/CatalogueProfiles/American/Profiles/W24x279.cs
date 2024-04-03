using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x279 : SingletonAmericanBase<W24x279>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X279";
        public Length Height => new Length(26.70, LengthUnit.Inch);
        public Length Width => new Length(13.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.09, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W24x279() { }
    }
}
