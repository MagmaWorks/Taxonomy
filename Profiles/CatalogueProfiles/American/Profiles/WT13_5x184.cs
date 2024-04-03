using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x184 : SingletonAmericanBase<WT13_5x184>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X184";
        public Length Height => new Length(15.20, LengthUnit.Inch);
        public Length Width => new Length(14.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.48, LengthUnit.Inch);
        public Length WebThickness => new Length(1.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(11.93, LengthUnit.Inch);

        public WT13_5x184() { }
    }
}
