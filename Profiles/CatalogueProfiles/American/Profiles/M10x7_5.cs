using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M10x7_5 : SingletonAmericanBase<M10x7_5>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M10X7.5";
        public Length Height => new Length(9.99, LengthUnit.Inch);
        public Length Width => new Length(2.69, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.17, LengthUnit.Inch);
        public Length WebThickness => new Length(0.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.245, LengthUnit.Inch);

        public M10x7_5() { }
    }
}
