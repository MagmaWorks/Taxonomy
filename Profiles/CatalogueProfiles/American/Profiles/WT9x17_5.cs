using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x17_5 : SingletonAmericanBase<WT9x17_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X17.5";
        public Length Height => new Length(8.85, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.02, LengthUnit.Inch);

        public WT9x17_5() { }
    }
}
