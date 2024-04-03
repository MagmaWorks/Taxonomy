using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x8 : SingletonAmericanBase<WT6x8>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X8";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(3.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.27, LengthUnit.Inch);
        public Length WebThickness => new Length(0.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.43, LengthUnit.Inch);

        public WT6x8() { }
    }
}
