using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x117 : SingletonAmericanBase<WT9x117>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X117";
        public Length Height => new Length(10.50, LengthUnit.Inch);
        public Length Width => new Length(11.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.11, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.99, LengthUnit.Inch);

        public WT9x117() { }
    }
}
