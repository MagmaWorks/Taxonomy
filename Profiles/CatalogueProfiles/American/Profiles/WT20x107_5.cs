using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x107_5 : SingletonAmericanBase<WT20x107_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X107.5";
        public Length Height => new Length(19.50, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.175, LengthUnit.Inch);

        public WT20x107_5() { }
    }
}