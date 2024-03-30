using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x105_5 : SingletonAmericanBase<WT7x105_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X105.5";
        public Length Height => new Length(7.86, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.98, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.25, LengthUnit.Inch);

        public WT7x105_5() { }
    }
}
