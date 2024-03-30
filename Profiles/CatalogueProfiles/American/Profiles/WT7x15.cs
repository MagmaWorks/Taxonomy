using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x15 : SingletonAmericanBase<WT7x15>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X15";
        public Length Height => new Length(6.92, LengthUnit.Inch);
        public Length Width => new Length(6.73, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.39, LengthUnit.Inch);
        public Length WebThickness => new Length(0.27, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.44, LengthUnit.Inch);

        public WT7x15() { }
    }
}
