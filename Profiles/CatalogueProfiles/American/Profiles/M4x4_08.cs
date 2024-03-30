using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M4x4_08 : SingletonAmericanBase<M4x4_08>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M4X4.08";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(2.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.17, LengthUnit.Inch);
        public Length WebThickness => new Length(0.12, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.39, LengthUnit.Inch);

        public M4x4_08() { }
    }
}
