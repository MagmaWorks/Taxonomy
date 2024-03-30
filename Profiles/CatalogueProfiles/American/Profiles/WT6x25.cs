using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x25 : SingletonAmericanBase<WT6x25>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X25";
        public Length Height => new Length(6.10, LengthUnit.Inch);
        public Length Width => new Length(8.08, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.64, LengthUnit.Inch);
        public Length WebThickness => new Length(0.37, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.715, LengthUnit.Inch);

        public WT6x25() { }
    }
}
