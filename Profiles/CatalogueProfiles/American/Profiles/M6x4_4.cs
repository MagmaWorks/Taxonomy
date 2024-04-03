using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M6x4_4 : SingletonAmericanBase<M6x4_4>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M6X4.4";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(1.84, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.17, LengthUnit.Inch);
        public Length WebThickness => new Length(0.11, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.195, LengthUnit.Inch);

        public M6x4_4() { }
    }
}
