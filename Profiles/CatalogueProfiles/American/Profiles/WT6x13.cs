using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x13 : SingletonAmericanBase<WT6x13>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X13";
        public Length Height => new Length(6.11, LengthUnit.Inch);
        public Length Width => new Length(6.49, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.43, LengthUnit.Inch);

        public WT6x13() { }
    }
}
