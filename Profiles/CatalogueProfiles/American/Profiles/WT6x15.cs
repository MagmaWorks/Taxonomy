using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x15 : SingletonAmericanBase<WT6x15>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X15";
        public Length Height => new Length(6.17, LengthUnit.Inch);
        public Length Width => new Length(6.52, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.43, LengthUnit.Inch);

        public WT6x15() { }
    }
}
