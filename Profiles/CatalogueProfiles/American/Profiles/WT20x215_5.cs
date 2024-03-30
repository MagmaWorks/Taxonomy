using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x215_5 : SingletonAmericanBase<WT20x215_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X215.5";
        public Length Height => new Length(20.60, LengthUnit.Inch);
        public Length Width => new Length(16.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.36, LengthUnit.Inch);
        public Length WebThickness => new Length(1.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.89, LengthUnit.Inch);

        public WT20x215_5() { }
    }
}
