using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M10x8 : SingletonAmericanBase<M10x8>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M10X8";
        public Length Height => new Length(9.95, LengthUnit.Inch);
        public Length Width => new Length(2.69, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.14, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.31, LengthUnit.Inch);

        public M10x8() { }
    }
}
