using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x129 : SingletonAmericanBase<WT9x129>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X129";
        public Length Height => new Length(10.70, LengthUnit.Inch);
        public Length Width => new Length(11.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.30, LengthUnit.Inch);
        public Length WebThickness => new Length(1.28, LengthUnit.Inch);
        public Length FilletRadius => new Length(8, LengthUnit.Inch);

        public WT9x129() { }
    }
}
