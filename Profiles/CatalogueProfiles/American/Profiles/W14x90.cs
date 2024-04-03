using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x90 : SingletonAmericanBase<W14x90>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X90";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(14.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.71, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W14x90() { }
    }
}
