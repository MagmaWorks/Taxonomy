using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x180_5 : SingletonAmericanBase<WT18x180_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X180.5";
        public Length Height => new Length(19.00, LengthUnit.Inch);
        public Length Width => new Length(16.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.01, LengthUnit.Inch);
        public Length WebThickness => new Length(1.12, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.83, LengthUnit.Inch);

        public WT18x180_5() { }
    }
}
