using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x808 : SingletonAmericanBase<W14x808>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X808";
        public Length Height => new Length(22.80, LengthUnit.Inch);
        public Length Width => new Length(18.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(5.12, LengthUnit.Inch);
        public Length WebThickness => new Length(3.74, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.63, LengthUnit.Inch);

        public W14x808() { }
    }
}
