using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x23 : SingletonAmericanBase<WT9x23>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X23";
        public Length Height => new Length(9.03, LengthUnit.Inch);
        public Length Width => new Length(6.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.84, LengthUnit.Inch);

        public WT9x23() { }
    }
}
