using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x109 : SingletonAmericanBase<W14x109>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X109";
        public Length Height => new Length(14.30, LengthUnit.Inch);
        public Length Width => new Length(14.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.86, LengthUnit.Inch);
        public Length WebThickness => new Length(0.53, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.29, LengthUnit.Inch);

        public W14x109() { }
    }
}
