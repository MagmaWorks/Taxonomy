using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x117_5 : SingletonAmericanBase<WT20x117_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X117.5";
        public Length Height => new Length(19.80, LengthUnit.Inch);
        public Length Width => new Length(11.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.775, LengthUnit.Inch);

        public WT20x117_5() { }
    }
}
