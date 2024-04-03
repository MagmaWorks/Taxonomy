using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x873 : SingletonAmericanBase<W14x873>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X873";
        public Length Height => new Length(23.60, LengthUnit.Inch);
        public Length Width => new Length(18.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(5.51, LengthUnit.Inch);
        public Length WebThickness => new Length(3.94, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.59, LengthUnit.Inch);

        public W14x873() { }
    }
}
