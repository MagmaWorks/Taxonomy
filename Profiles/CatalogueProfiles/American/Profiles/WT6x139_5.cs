using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x139_5 : SingletonAmericanBase<WT6x139_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X139.5";
        public Length Height => new Length(7.93, LengthUnit.Inch);
        public Length Width => new Length(13.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.47, LengthUnit.Inch);
        public Length WebThickness => new Length(1.53, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.715, LengthUnit.Inch);

        public WT6x139_5() { }
    }
}
