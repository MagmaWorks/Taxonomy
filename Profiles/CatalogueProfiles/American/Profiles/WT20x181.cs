using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x181 : SingletonAmericanBase<WT20x181>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X181";
        public Length Height => new Length(20.30, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.01, LengthUnit.Inch);
        public Length WebThickness => new Length(1.12, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.11, LengthUnit.Inch);

        public WT20x181() { }
    }
}
