using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT3x10 : SingletonAmericanBase<WT3x10>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT3X10";
        public Length Height => new Length(3.10, LengthUnit.Inch);
        public Length Width => new Length(6.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.37, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.26, LengthUnit.Inch);

        public WT3x10() { }
    }
}
