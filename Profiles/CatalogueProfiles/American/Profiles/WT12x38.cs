using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x38 : SingletonAmericanBase<WT12x38>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X38";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(8.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.68, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.095, LengthUnit.Inch);

        public WT12x38() { }
    }
}
