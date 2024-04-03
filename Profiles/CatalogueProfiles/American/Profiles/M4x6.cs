using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M4x6 : SingletonAmericanBase<M4x6>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M4X6";
        public Length Height => new Length(3.80, LengthUnit.Inch);
        public Length Width => new Length(3.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.16, LengthUnit.Inch);
        public Length WebThickness => new Length(0.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.315, LengthUnit.Inch);

        public M4x6() { }
    }
}
