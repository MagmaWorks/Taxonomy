using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x30 : SingletonAmericanBase<W14x30>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X30";
        public Length Height => new Length(13.80, LengthUnit.Inch);
        public Length Width => new Length(6.73, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.39, LengthUnit.Inch);
        public Length WebThickness => new Length(0.27, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.695, LengthUnit.Inch);

        public W14x30() { }
    }
}
