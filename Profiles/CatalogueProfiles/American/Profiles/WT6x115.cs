using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x115 : SingletonAmericanBase<WT6x115>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X115";
        public Length Height => new Length(7.53, LengthUnit.Inch);
        public Length Width => new Length(12.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.07, LengthUnit.Inch);
        public Length WebThickness => new Length(1.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.135, LengthUnit.Inch);

        public WT6x115() { }
    }
}
