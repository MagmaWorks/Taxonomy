using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x105 : SingletonAmericanBase<WT6x105>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X105";
        public Length Height => new Length(7.36, LengthUnit.Inch);
        public Length Width => new Length(12.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.90, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.31, LengthUnit.Inch);

        public WT6x105() { }
    }
}
