using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x302_5 : SingletonAmericanBase<WT7x302_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X302.5";
        public Length Height => new Length(10.50, LengthUnit.Inch);
        public Length Width => new Length(17.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.16, LengthUnit.Inch);
        public Length WebThickness => new Length(2.60, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.64, LengthUnit.Inch);

        public WT7x302_5() { }
    }
}
