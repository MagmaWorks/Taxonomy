using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x178_5 : SingletonAmericanBase<WT15x178_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X178.5";
        public Length Height => new Length(16.40, LengthUnit.Inch);
        public Length Width => new Length(15.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.24, LengthUnit.Inch);
        public Length WebThickness => new Length(1.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.1, LengthUnit.Inch);

        public WT15x178_5() { }
    }
}
