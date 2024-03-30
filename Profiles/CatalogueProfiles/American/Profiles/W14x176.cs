using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x176 : SingletonAmericanBase<W14x176>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X176";
        public Length Height => new Length(15.20, LengthUnit.Inch);
        public Length Width => new Length(15.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.29, LengthUnit.Inch);

        public W14x176() { }
    }
}
