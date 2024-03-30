using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x48 : SingletonAmericanBase<W14x48>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X48";
        public Length Height => new Length(13.80, LengthUnit.Inch);
        public Length Width => new Length(8.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.60, LengthUnit.Inch);
        public Length WebThickness => new Length(0.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.86, LengthUnit.Inch);

        public W14x48() { }
    }
}
