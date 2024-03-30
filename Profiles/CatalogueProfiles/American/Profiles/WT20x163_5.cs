using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x163_5 : SingletonAmericanBase<WT20x163_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X163.5";
        public Length Height => new Length(20.40, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.15, LengthUnit.Inch);

        public WT20x163_5() { }
    }
}
