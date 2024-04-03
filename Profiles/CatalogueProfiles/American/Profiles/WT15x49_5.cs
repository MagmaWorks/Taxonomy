using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x49_5 : SingletonAmericanBase<WT15x49_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X49.5";
        public Length Height => new Length(14.80, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.67, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.48, LengthUnit.Inch);

        public WT15x49_5() { }
    }
}
