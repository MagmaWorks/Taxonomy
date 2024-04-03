using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x38 : SingletonAmericanBase<WT9x38>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X38";
        public Length Height => new Length(9.11, LengthUnit.Inch);
        public Length Width => new Length(11.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.68, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x38() { }
    }
}
