using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x342 : SingletonAmericanBase<W14x342>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X342";
        public Length Height => new Length(17.50, LengthUnit.Inch);
        public Length Width => new Length(16.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.47, LengthUnit.Inch);
        public Length WebThickness => new Length(1.54, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.28, LengthUnit.Inch);

        public W14x342() { }
    }
}
