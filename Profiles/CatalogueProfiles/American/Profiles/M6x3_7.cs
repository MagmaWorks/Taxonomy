using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M6x3_7 : SingletonAmericanBase<M6x3_7>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M6X3.7";
        public Length Height => new Length(5.92, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.13, LengthUnit.Inch);
        public Length WebThickness => new Length(0.10, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.2, LengthUnit.Inch);

        public M6x3_7() { }
    }
}
