using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x99 : SingletonAmericanBase<W14x99>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X99";
        public Length Height => new Length(14.20, LengthUnit.Inch);
        public Length Width => new Length(14.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.78, LengthUnit.Inch);
        public Length WebThickness => new Length(0.49, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.32, LengthUnit.Inch);

        public W14x99() { }
    }
}
