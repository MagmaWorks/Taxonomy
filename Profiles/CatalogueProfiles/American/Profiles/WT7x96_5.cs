using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x96_5 : SingletonAmericanBase<WT7x96_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X96.5";
        public Length Height => new Length(7.74, LengthUnit.Inch);
        public Length Width => new Length(15.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.89, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.365, LengthUnit.Inch);

        public WT7x96_5() { }
    }
}
