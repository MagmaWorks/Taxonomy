using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x95 : SingletonAmericanBase<WT6x95>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X95";
        public Length Height => new Length(7.19, LengthUnit.Inch);
        public Length Width => new Length(12.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.74, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.49, LengthUnit.Inch);

        public WT6x95() { }
    }
}
