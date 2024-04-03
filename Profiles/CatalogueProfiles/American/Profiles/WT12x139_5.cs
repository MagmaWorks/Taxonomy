using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x139_5 : SingletonAmericanBase<WT12x139_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X139.5";
        public Length Height => new Length(13.40, LengthUnit.Inch);
        public Length Width => new Length(13.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.09, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.81, LengthUnit.Inch);

        public WT12x139_5() { }
    }
}
