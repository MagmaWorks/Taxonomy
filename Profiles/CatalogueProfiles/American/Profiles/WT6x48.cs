using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x48 : SingletonAmericanBase<WT6x48>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X48";
        public Length Height => new Length(6.36, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.90, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x48() { }
    }
}
