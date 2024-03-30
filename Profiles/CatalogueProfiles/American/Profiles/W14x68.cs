using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x68 : SingletonAmericanBase<W14x68>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X68";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.72, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.84, LengthUnit.Inch);

        public W14x68() { }
    }
}
