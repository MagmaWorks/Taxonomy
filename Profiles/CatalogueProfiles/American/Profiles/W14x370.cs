using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x370 : SingletonAmericanBase<W14x370>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X370";
        public Length Height => new Length(17.90, LengthUnit.Inch);
        public Length Width => new Length(16.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.66, LengthUnit.Inch);
        public Length WebThickness => new Length(1.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W14x370() { }
    }
}
