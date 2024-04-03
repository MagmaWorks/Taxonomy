using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x116_5 : SingletonAmericanBase<WT7x116_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X116.5";
        public Length Height => new Length(8.02, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.72, LengthUnit.Inch);
        public Length WebThickness => new Length(1.07, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x116_5() { }
    }
}
